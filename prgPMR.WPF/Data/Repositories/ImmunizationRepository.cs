using Microsoft.EntityFrameworkCore;
using prgPMR.WPF.Core.Interfaces;
using prgPMR.WPF.Core.Models;
using System.Data;

namespace prgPMR.WPF.Data.Repositories;

public class ImmunizationRepository : IImmunizationRepository
{
    private readonly AppDbContext _db;

    public ImmunizationRepository(AppDbContext db) => _db = db;

    /// <summary>
    /// Returns one ImmunizationSummary per vaccine for the given user.
    /// Each summary aggregates all individual dose rows into a single grid row
    /// with DateDose1 … DateDose5 and a DateLastDose (max date).
    ///
    /// Vaccine name / group are enriched via a raw ADO.NET query because
    /// VaccineName is intentionally kept out of the EF model (avoiding the
    /// TPH inheritance-key constraint that would result from
    /// VaccineName : LookupItem inside the DbContext).
    /// </summary>
    public async Task<IReadOnlyList<ImmunizationSummary>> GetSummariesAsync(int userId)
    {
        // ── 1. Load raw dose records (EF) ────────────────────────────────────
        var doses = await _db.Immunizations
            .Where(i => i.UserId == userId)
            .ToListAsync();

        if (doses.Count == 0)
            return Array.Empty<ImmunizationSummary>();

        // ── 2. Enrich with vaccine display names (raw ADO.NET) ────────────────
        var vaccineMap = await LoadVaccineMapAsync();

        foreach (var d in doses)
        {
            if (vaccineMap.TryGetValue(d.SelectVaccineNameId, out var vn))
            {
                d.VaccineName  = vn.Name;
                d.VaccineGroup = vn.Group;
            }
        }

        // ── 3. Group doses by vaccine, build summary rows ─────────────────────
        var summaries = doses
            .GroupBy(d => d.SelectVaccineNameId)
            .Select(g =>
            {
                var sortedDoses = g.OrderByDescending(d => d.DateGiven).ToList();
                return new ImmunizationSummary
                {
                    SelectVaccineNameId = g.Key,
                    VaccineName         = g.First().VaccineName ?? string.Empty,
                    VaccineGroup        = g.First().VaccineGroup,
                    TotalDoses          = sortedDoses.Count,
                    DateLastDose        = sortedDoses.Select(d => (DateOnly?)d.DateGiven).Max(),
                    Dose1               = sortedDoses.Count > 0 ? sortedDoses[0].DateGiven : null,
                    Dose2               = sortedDoses.Count > 1 ? sortedDoses[1].DateGiven : null,
                    Dose3               = sortedDoses.Count > 2 ? sortedDoses[2].DateGiven : null,
                    Dose4               = sortedDoses.Count > 3 ? sortedDoses[3].DateGiven : null,
                    Dose5               = sortedDoses.Count > 4 ? sortedDoses[4].DateGiven : null,
                    Doses               = sortedDoses
                };
            })
            .OrderBy(s => s.VaccineName)
            .ToList();

        return summaries;
    }

    public async Task<IReadOnlyList<ImmunizationDetail>> GetDosesAsync(int userId, int vaccineNameId)
        => await _db.Immunizations
            .Where(i => i.UserId == userId && i.SelectVaccineNameId == vaccineNameId)
            .OrderByDescending(i => i.DateGiven)
            .ToListAsync();

    public async Task<ImmunizationDetail?> GetDoseByIdAsync(int id)
        => await _db.Immunizations.FindAsync(id);

    public async Task<int> AddDoseAsync(ImmunizationDetail detail)
    {
        _db.Immunizations.Add(detail);
        await _db.SaveChangesAsync();
        return detail.ImmunizationDetailsId;
    }

    public async Task UpdateDoseAsync(ImmunizationDetail detail)
    {
        _db.Immunizations.Update(detail);
        await _db.SaveChangesAsync();
    }

    public async Task DeleteDoseAsync(int id)
    {
        var entity = await _db.Immunizations.FindAsync(id);
        if (entity is not null)
        {
            _db.Immunizations.Remove(entity);
            await _db.SaveChangesAsync();
        }
    }

    // ── Private helpers ──────────────────────────────────────────────────────

    /// <summary>
    /// Reads tblSelectVaccineNames via raw ADO.NET and returns a
    /// SelectVaccineNameID → (VaccineName, VaccineGroup) dictionary.
    /// </summary>
    private async Task<Dictionary<int, (string Name, string? Group)>> LoadVaccineMapAsync()
    {
        var map  = new Dictionary<int, (string, string?)>();
        var conn = _db.Database.GetDbConnection();

        bool needsClose = conn.State != ConnectionState.Open;
        if (needsClose)
            await conn.OpenAsync();

        try
        {
            using var cmd   = conn.CreateCommand();
            cmd.CommandText = "SELECT SelectVaccineNameID, VaccineName, VaccineGroup " +
                              "FROM tblSelectVaccineNames";

            using var rdr = await cmd.ExecuteReaderAsync();
            while (await rdr.ReadAsync())
                map[rdr.GetInt32(0)] = (
                    rdr.IsDBNull(1) ? string.Empty : rdr.GetString(1),
                    rdr.IsDBNull(2) ? null         : rdr.GetString(2));
        }
        finally
        {
            if (needsClose)
                conn.Close();
        }

        return map;
    }
}
