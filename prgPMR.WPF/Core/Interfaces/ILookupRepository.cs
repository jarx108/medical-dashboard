using prgPMR.WPF.Core.Models.Lookups;

namespace prgPMR.WPF.Core.Interfaces;

/// <summary>
/// Provides all reference/lookup table data used to populate ComboBoxes.
/// Cached after first load — lookup tables rarely change.
/// </summary>
public interface ILookupRepository
{
    Task<IReadOnlyList<VaccineName>>   GetVaccineNamesAsync();
    Task<IReadOnlyList<Facility>>      GetFacilitiesAsync();
    Task<IReadOnlyList<Doctor>>        GetDoctorsAsync();
    Task<IReadOnlyList<LookupItem>>    GetManufacturersAsync();
    Task<IReadOnlyList<LookupItem>>    GetMedicationsAsync();
    Task<IReadOnlyList<LookupItem>>    GetMedicalConditionsAsync();
    Task<IReadOnlyList<LookupItem>>    GetBloodworkIndicatorsAsync();
    Task<IReadOnlyList<LookupItem>>    GetBloodworkGroupsAsync();
    Task<IReadOnlyList<LookupItem>>    GetTestTypesAsync();
    Task<IReadOnlyList<LookupItem>>    GetFamilyMembersAsync();
}
