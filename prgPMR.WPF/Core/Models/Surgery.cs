namespace prgPMR.WPF.Core.Models;

/// <summary>Maps to tblSurgeries.</summary>
public class Surgery
{
    public int       SurgeryId                { get; set; }
    public int       UserId                   { get; set; }
    public int?      SelectFacilityId         { get; set; }
    public int?      SelectDoctorId           { get; set; }
    public DateOnly? SurgeryDate              { get; set; }
    public int       SelectMedicalConditionId { get; set; }
    public string?   Notes                    { get; set; }
    public byte[]?   PdfFile                  { get; set; }
    public byte[]?   ImgFile                  { get; set; }

    public string?   ConditionName { get; set; }
    public string?   DoctorName    { get; set; }
    public string?   FacilityName  { get; set; }
}
