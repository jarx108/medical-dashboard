using prgPMR.WPF.Core.Models;

namespace prgPMR.WPF.Core.Interfaces;

public interface IImmunizationRepository
{
    /// <summary>Returns one summary row per vaccine (doses aggregated).</summary>
    Task<IReadOnlyList<ImmunizationSummary>> GetSummariesAsync(int userId);

    /// <summary>Returns all dose records for a specific vaccine name ID.</summary>
    Task<IReadOnlyList<ImmunizationDetail>> GetDosesAsync(int userId, int vaccineNameId);

    Task<ImmunizationDetail?> GetDoseByIdAsync(int immunizationDetailsId);
    Task<int>                 AddDoseAsync(ImmunizationDetail detail);
    Task                      UpdateDoseAsync(ImmunizationDetail detail);
    Task                      DeleteDoseAsync(int immunizationDetailsId);
}
