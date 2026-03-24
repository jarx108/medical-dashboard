namespace prgPMR.WPF.Core.Models.Lookups;

/// <summary>
/// Generic lookup/reference table item used in ComboBoxes.
/// All reference tables (Vaccine, Facility, Doctor, etc.) map to this shape for UI binding.
/// </summary>
public class LookupItem
{
    public int    Id          { get; set; }
    public string DisplayName { get; set; } = string.Empty;

    public override string ToString() => DisplayName;
}

/// <summary>Vaccine name from tblSelectVaccineNames.</summary>
public class VaccineName : LookupItem
{
    public string? VaccineGroup { get; set; }
}

/// <summary>Facility from tblSelectFacilities.</summary>
public class Facility : LookupItem
{
    public string? Location     { get; set; }
    public string? Phone        { get; set; }
    public bool    IsHospital   { get; set; }
    public bool    IsPharmacy   { get; set; }
    public bool    IsSurgery    { get; set; }
    public bool    IsTestCenter { get; set; }
    public bool    IsDoctorOffice { get; set; }
}

/// <summary>Doctor from tblSelectDoctors.</summary>
public class Doctor : LookupItem
{
    public string  Lastname   { get; set; } = string.Empty;
    public string  Firstname  { get; set; } = string.Empty;
    public string  Specialty  { get; set; } = string.Empty;
    public string? Location   { get; set; }
    public string? Phone      { get; set; }
}
