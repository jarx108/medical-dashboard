namespace prgPMR.WPF.Core.Models;

/// <summary>Maps to tblBloodwork.</summary>
public class BloodworkRecord
{
    public int       BloodworkId              { get; set; }
    public int       UserId                   { get; set; }
    public int       SelectBloodworkIndiNameId { get; set; }
    public string    Result                   { get; set; } = string.Empty;
    public int?      SelectDoctorId           { get; set; }
    public DateOnly? BloodworkDate            { get; set; }
    public int?      SelectFacilityId         { get; set; }
    public string?   Notes                    { get; set; }
    public byte[]?   PdfFile                  { get; set; }
    public byte[]?   ImgFile                  { get; set; }

    public string?   IndicatorName { get; set; }
    public string?   GroupName     { get; set; }
    public string?   DoctorName    { get; set; }
    public string?   FacilityName  { get; set; }
}
