namespace prgPMR.WPF.Core.Models;

/// <summary>Maps to tblHospitalizations.</summary>
public class Hospitalization
{
    public int       HospitalizationId        { get; set; }
    public int       UserId                   { get; set; }
    public int       SelectMedicalConditionId { get; set; }
    public int?      SelectDoctorId           { get; set; }
    public int?      SelectFacilityId         { get; set; }
    public DateOnly? AdmissionDate            { get; set; }
    public DateOnly? DischargeDate            { get; set; }
    public string?   Notes                    { get; set; }
    public byte[]?   PdfFile                  { get; set; }
    public byte[]?   ImgFile                  { get; set; }

    public string?   ConditionName { get; set; }
    public string?   DoctorName    { get; set; }
    public string?   FacilityName  { get; set; }
}
