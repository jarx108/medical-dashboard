namespace prgPMR.WPF.Core.Models;

/// <summary>Maps to tblUsers.</summary>
public class User
{
    public int      UserId    { get; set; }
    public string   Username  { get; set; } = string.Empty;
    public string   Password  { get; set; } = string.Empty;
    public string   Lastname  { get; set; } = string.Empty;
    public string   Firstname { get; set; } = string.Empty;
    public DateOnly? DOB      { get; set; }

    public string FullName => $"{Firstname} {Lastname}";
}
