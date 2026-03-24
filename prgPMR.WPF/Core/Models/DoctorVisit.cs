namespace prgPMR.WPF.Core.Models;

/// <summary>Maps to tblDoctorVisits.</summary>
public class DoctorVisit
{
    public int       DoctorVisitId            { get; set; }
    public int       UserId                   { get; set; }
    public int       SelectDoctorId           { get; set; }
    public int       SelectMedicalConditionId { get; set; }
    public DateOnly? DoctorVisitDate          { get; set; }
    public string?   Notes                    { get; set; }
    public byte[]?   PdfFile                  { get; set; }
    public byte[]?   ImgFile                  { get; set; }

    public string?   DoctorName    { get; set; }
    public string?   ConditionName { get; set; }
}
