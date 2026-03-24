namespace prgPMR.WPF.Core.Models;

/// <summary>Maps to tblMedicationLists.</summary>
public class Medication
{
    public int      MedicationListId          { get; set; }
    public int      UserId                    { get; set; }
    public int      SelectMedicationId        { get; set; }
    public int?     SelectionDoctorId         { get; set; }
    public int?     SelectMedicalConditionId  { get; set; }
    public int?     SelectFacilityId          { get; set; }
    public DateOnly? MedicationListDate       { get; set; }
    public string?  RxNumber                  { get; set; }
    public int?     Qty                       { get; set; }
    public string?  Dosing                    { get; set; }
    public string?  Notes                     { get; set; }
    public byte[]?  PdfFile                   { get; set; }
    public byte[]?  ImgFile                   { get; set; }

    // Resolved lookup display names
    public string?  MedicationName    { get; set; }
    public string?  DoctorName        { get; set; }
    public string?  ConditionName     { get; set; }
    public string?  FacilityName      { get; set; }
}
