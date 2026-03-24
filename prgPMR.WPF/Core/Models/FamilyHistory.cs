namespace prgPMR.WPF.Core.Models;

/// <summary>Maps to tblFamilyHistories — links a user to a family member.</summary>
public class FamilyHistory
{
    public int FamilyHistoryId     { get; set; }
    public int UserId              { get; set; }
    public int SelectFamilyMemberId { get; set; }

    // Joined data
    public FamilyMember?                    Member     { get; set; }
    public List<FamilyMemberCondition>      Conditions { get; set; } = [];
}

/// <summary>Maps to tblFamilyMembers.</summary>
public class FamilyMember
{
    public int      FamilyMemberId   { get; set; }
    public string   Lastname         { get; set; } = string.Empty;
    public string   Firstname        { get; set; } = string.Empty;
    public bool?    Alive            { get; set; }
    public DateOnly? DOB             { get; set; }
    public DateOnly? DOD             { get; set; }
    public string?  ApproxYearBirth  { get; set; }
    public string?  ApproxYearDeath  { get; set; }
    public string?  Notes            { get; set; }

    public string FullName => $"{Firstname} {Lastname}";
}

/// <summary>Maps to tblFamilyMemberMedicalConditions.</summary>
public class FamilyMemberCondition
{
    public int    FamilyMemberMedicalConditionId { get; set; }
    public int    FamilyMemberId                 { get; set; }
    public int    SelectMedicalConditionId       { get; set; }
    public int?   AgeOnsetCondition              { get; set; }

    public string? ConditionName { get; set; }
}
