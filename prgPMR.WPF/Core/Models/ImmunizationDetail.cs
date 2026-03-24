namespace prgPMR.WPF.Core.Models;

/// <summary>
/// Maps to tblImmunizationDetails.
/// One row per vaccine dose administered.
/// </summary>
public class ImmunizationDetail
{
    public int      ImmunizationDetailsId  { get; set; }
    public int      SelectVaccineNameId    { get; set; }
    public int      UserId                 { get; set; }
    public string?  DetailName             { get; set; }
    public DateOnly DateGiven              { get; set; }
    public int?     SelectFacilityId       { get; set; }
    public int?     SelectManufacturerId   { get; set; }
    public string?  RxNum                  { get; set; }
    public string?  NdcNum                 { get; set; }
    public string?  LotNum                 { get; set; }
    public string?  Notes                  { get; set; }
    public byte[]?  PdfFile                { get; set; }
    public byte[]?  ImgFile                { get; set; }

    // Navigation properties populated via joins
    public string?  VaccineName   { get; set; }
    public string?  VaccineGroup  { get; set; }
    public string?  FacilityName  { get; set; }
    public string?  Manufacturer  { get; set; }
}

/// <summary>
/// Aggregated grid row — one row per vaccine showing all doses.
/// Built in the repository by grouping tblImmunizationDetails by VaccineNameId.
/// </summary>
public class ImmunizationSummary
{
    public int       SelectVaccineNameId { get; set; }
    public string    VaccineName         { get; set; } = string.Empty;
    public string?   VaccineGroup        { get; set; }
    public int       TotalDoses          { get; set; }
    public DateOnly? DateLastDose        { get; set; }
    public DateOnly? Dose1               { get; set; }
    public DateOnly? Dose2               { get; set; }
    public DateOnly? Dose3               { get; set; }
    public DateOnly? Dose4               { get; set; }
    public DateOnly? Dose5               { get; set; }

    /// <summary>All raw dose records for this vaccine — used to populate detail.</summary>
    public List<ImmunizationDetail> Doses { get; set; } = [];
}
