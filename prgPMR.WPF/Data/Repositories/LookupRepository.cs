using Microsoft.EntityFrameworkCore;
using prgPMR.WPF.Core.Interfaces;
using prgPMR.WPF.Core.Models.Lookups;
using System.Data;
using System.Data.Common;

namespace prgPMR.WPF.Data.Repositories;

/// <summary>
/// Loads reference/lookup tables used to populate ComboBoxes.
///
/// Lookup tables (VaccineNames, Facilities, Doctors, etc.) are intentionally
/// kept OUT of the EF model to avoid the TPH inheritance-mapping constraint
/// (EF requires a single root key when derived classes share a base type).
/// Instead, all queries go through a raw ADO.NET helper that uses the
/// underlying DbConnection managed by EF Core.
///
/// Results are cached in memory after first load — lookup data rarely changes.
/// </summary>
public class LookupRepository : ILookupRepository
{
    private readonly AppDbContext _db;

    // Simple in-memory cache — keyed by a short string identifier
    private readonly Dictionary<string, object> _cache = new();

    public LookupRepository(AppDbContext db) => _db = db;

    // ── Typed lookup methods ─────────────────────────────────────────────────

    public Task<IReadOnlyList<VaccineName>> GetVaccineNamesAsync()
        => QueryAsync(
            "vaccines",
            "SELECT SelectVaccineNameID, VaccineName, VaccineGroup " +
            "FROM tblSelectVaccineNames ORDER BY VaccineName",
            r => new VaccineName
            {
                Id           = r.GetInt32(0),
                DisplayName  = r.IsDBNull(1) ? string.Empty : r.GetString(1),
                VaccineGroup = r.IsDBNull(2) ? null         : r.GetString(2)
            });

    public Task<IReadOnlyList<Facility>> GetFacilitiesAsync()
        => QueryAsync(
            "facilities",
            "SELECT SelectFacilityId, SelectFacilityName " +
            "FROM tblSelectFacilities ORDER BY SelectFacilityName",
            r => new Facility
            {
                Id          = r.GetInt32(0),
                DisplayName = r.IsDBNull(1) ? string.Empty : r.GetString(1)
            });

    public Task<IReadOnlyList<Doctor>> GetDoctorsAsync()
        => QueryAsync(
            "doctors",
            "SELECT SelectDoctorId, Lastname, Firstname " +
            "FROM tblSelectDoctors ORDER BY Lastname",
            r =>
            {
                var last  = r.IsDBNull(1) ? string.Empty : r.GetString(1);
                var first = r.IsDBNull(2) ? string.Empty : r.GetString(2);
                return new Doctor
                {
                    Id          = r.GetInt32(0),
                    DisplayName = string.IsNullOrEmpty(first) ? last : $"{last}, {first}",
                    Lastname    = last,
                    Firstname   = first
                };
            });

    // ── Generic LookupItem methods ───────────────────────────────────────────

    public Task<IReadOnlyList<LookupItem>> GetManufacturersAsync()
        => LookupAsync("manufacturers",
            "SELECT SelectManufacturerID, ManufacturerName " +
            "FROM tblSelectManufacturers ORDER BY ManufacturerName");

    public Task<IReadOnlyList<LookupItem>> GetMedicationsAsync()
        => LookupAsync("medications",
            "SELECT SelectMedicationID, MedicationName " +
            "FROM tblSelectMedications ORDER BY MedicationName");

    public Task<IReadOnlyList<LookupItem>> GetMedicalConditionsAsync()
        => LookupAsync("conditions",
            "SELECT SelectMedicalConditionID, MedicalConditionName " +
            "FROM tblSelectMedicalConditions ORDER BY MedicalConditionName");

    public Task<IReadOnlyList<LookupItem>> GetBloodworkIndicatorsAsync()
        => LookupAsync("bwIndicators",
            "SELECT SelectBloodworkIndiNameID, BloodworkIndiName " +
            "FROM tblSelectBloodworkIndiNames ORDER BY BloodworkIndiName");

    public Task<IReadOnlyList<LookupItem>> GetBloodworkGroupsAsync()
        => LookupAsync("bwGroups",
            "SELECT SelectBloodworkGroupNameID, BloodworkGroupName " +
            "FROM tblSelectBloodworkGroupNames ORDER BY BloodworkGroupName");

    public Task<IReadOnlyList<LookupItem>> GetTestTypesAsync()
        => LookupAsync("testTypes",
            "SELECT SelectTestTypeID, TestTypeName " +
            "FROM tblSelectTestTypes ORDER BY TestTypeName");

    public Task<IReadOnlyList<LookupItem>> GetFamilyMembersAsync()
        => LookupAsync("familyMembers",
            "SELECT FamilyMemberId, (Firstname || ' ' || Lastname) " +
            "FROM tblFamilyMembers ORDER BY Lastname");

    // ── Helpers ──────────────────────────────────────────────────────────────

    /// <summary>
    /// Convenience overload that projects each row to a plain <see cref="LookupItem"/>
    /// (col 0 → Id, col 1 → DisplayName).
    /// </summary>
    private Task<IReadOnlyList<LookupItem>> LookupAsync(string cacheKey, string sql)
        => QueryAsync(cacheKey, sql,
            r => new LookupItem
            {
                Id          = r.GetInt32(0),
                DisplayName = r.IsDBNull(1) ? string.Empty : r.GetString(1)
            });

    /// <summary>
    /// Executes <paramref name="sql"/> via the raw ADO.NET connection that EF Core
    /// manages, projects each row through <paramref name="map"/>, caches, and returns
    /// the result.
    ///
    /// We open the connection only if EF hasn't already opened it, and close it
    /// only if we opened it — so concurrent EF operations are not disrupted.
    /// </summary>
    private async Task<IReadOnlyList<T>> QueryAsync<T>(
        string cacheKey, string sql, Func<DbDataReader, T> map)
    {
        if (_cache.TryGetValue(cacheKey, out var cached))
            return (IReadOnlyList<T>)cached;

        DbConnection conn = _db.Database.GetDbConnection();
        bool needsClose   = conn.State != ConnectionState.Open;

        if (needsClose)
            await conn.OpenAsync();

        try
        {
            var list = new List<T>();

            using var cmd    = conn.CreateCommand();
            cmd.CommandText  = sql;

            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
                list.Add(map(reader));

            _cache[cacheKey] = list;
            return list;
        }
        finally
        {
            if (needsClose)
                conn.Close();
        }
    }
}
