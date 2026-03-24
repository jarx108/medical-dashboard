namespace prgPMR.WPF.Core.Models;

/// <summary>Maps to tblTests.</summary>
public class MedicalTest
{
    public int       TestsId                  { get; set; }
    public int       UserId                   { get; set; }
    public int       SelectTestTypeId         { get; set; }
    public string?   BodyPart                 { get; set; }
    public int?      SelectDoctorId           { get; set; }
    public int?      SelectFacilityId         { get; set; }
    public int?      SelectMedicalConditionId { get; set; }
    public string?   Results                  { get; set; }
    public DateOnly? TestDate                 { get; set; }
    public string?   Notes                    { get; set; }
    public byte[]?   PdfFile                  { get; set; }
    public byte[]?   ImgFile                  { get; set; }

    public string?   TestTypeName  { get; set; }
    public string?   DoctorName    { get; set; }
    public string?   FacilityName  { get; set; }
    public string?   ConditionName { get; set; }
}
