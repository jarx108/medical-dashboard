using Microsoft.EntityFrameworkCore;
using prgPMR.WPF.Core.Models;

namespace prgPMR.WPF.Data;

/// <summary>
/// EF Core DbContext mapped to the SQLite database (pmr.db).
///
/// SQLite replaces SQL Server — zero-install, single portable file,
/// ideal for a local personal-use app.
///
/// Table names match the existing SQL Server schema (tblXxx) so that
/// data can be migrated via a one-time export/import if needed.
/// </summary>
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // ── Main data tables ────────────────────────────────────────────────
    public DbSet<User>                 Users             { get; set; }
    public DbSet<ImmunizationDetail>   Immunizations     { get; set; }
    public DbSet<Medication>           Medications       { get; set; }
    public DbSet<DoctorVisit>          DoctorVisits      { get; set; }
    public DbSet<BloodworkRecord>      Bloodwork         { get; set; }
    public DbSet<Surgery>              Surgeries         { get; set; }
    public DbSet<Hospitalization>      Hospitalizations  { get; set; }
    public DbSet<MedicalTest>          Tests             { get; set; }
    public DbSet<FamilyHistory>        FamilyHistories   { get; set; }
    public DbSet<FamilyMember>         FamilyMembers     { get; set; }
    public DbSet<FamilyMemberCondition> FamilyMemberConditions { get; set; }

    protected override void OnModelCreating(ModelBuilder mb)
    {
        // ── Users ────────────────────────────────────────────────────────
        mb.Entity<User>(e =>
        {
            e.ToTable("tblUsers");
            e.HasKey(x => x.UserId);
            e.Property(x => x.DOB).HasConversion(
                v => v.HasValue ? v.Value.ToString("yyyy-MM-dd") : null,
                v => v != null ? DateOnly.Parse(v) : (DateOnly?)null);
            // Unmapped computed property
            e.Ignore(x => x.FullName);
        });

        // ── Immunizations ─────────────────────────────────────────────────
        mb.Entity<ImmunizationDetail>(e =>
        {
            e.ToTable("tblImmunizationDetails");
            e.HasKey(x => x.ImmunizationDetailsId);
            e.Property(x => x.DateGiven).HasConversion(
                v => v.ToString("yyyy-MM-dd"),
                v => DateOnly.Parse(v));
            // Resolved display names are not DB columns
            e.Ignore(x => x.VaccineName);
            e.Ignore(x => x.VaccineGroup);
            e.Ignore(x => x.FacilityName);
            e.Ignore(x => x.Manufacturer);
        });

        // ── Medications ───────────────────────────────────────────────────
        mb.Entity<Medication>(e =>
        {
            e.ToTable("tblMedicationLists");
            e.HasKey(x => x.MedicationListId);
            e.Property(x => x.MedicationListDate).HasConversion(
                v => v.HasValue ? v.Value.ToString("yyyy-MM-dd") : null,
                v => v != null ? DateOnly.Parse(v) : (DateOnly?)null);
            e.Ignore(x => x.MedicationName);
            e.Ignore(x => x.DoctorName);
            e.Ignore(x => x.ConditionName);
            e.Ignore(x => x.FacilityName);
        });

        // ── Doctor Visits ─────────────────────────────────────────────────
        mb.Entity<DoctorVisit>(e =>
        {
            e.ToTable("tblDoctorVisits");
            e.HasKey(x => x.DoctorVisitId);
            e.Property(x => x.DoctorVisitDate).HasConversion(
                v => v.HasValue ? v.Value.ToString("yyyy-MM-dd") : null,
                v => v != null ? DateOnly.Parse(v) : (DateOnly?)null);
            e.Ignore(x => x.DoctorName);
            e.Ignore(x => x.ConditionName);
        });

        // ── Bloodwork ─────────────────────────────────────────────────────
        mb.Entity<BloodworkRecord>(e =>
        {
            e.ToTable("tblBloodwork");
            e.HasKey(x => x.BloodworkId);
            e.Property(x => x.BloodworkDate).HasConversion(
                v => v.HasValue ? v.Value.ToString("yyyy-MM-dd") : null,
                v => v != null ? DateOnly.Parse(v) : (DateOnly?)null);
            e.Ignore(x => x.IndicatorName);
            e.Ignore(x => x.GroupName);
            e.Ignore(x => x.DoctorName);
            e.Ignore(x => x.FacilityName);
        });

        // ── Surgeries ─────────────────────────────────────────────────────
        mb.Entity<Surgery>(e =>
        {
            e.ToTable("tblSurgeries");
            e.HasKey(x => x.SurgeryId);
            e.Property(x => x.SurgeryDate).HasConversion(
                v => v.HasValue ? v.Value.ToString("yyyy-MM-dd") : null,
                v => v != null ? DateOnly.Parse(v) : (DateOnly?)null);
            e.Ignore(x => x.ConditionName);
            e.Ignore(x => x.DoctorName);
            e.Ignore(x => x.FacilityName);
        });

        // ── Hospitalizations ──────────────────────────────────────────────
        mb.Entity<Hospitalization>(e =>
        {
            e.ToTable("tblHospitalizations");
            e.HasKey(x => x.HospitalizationId);
            e.Property(x => x.AdmissionDate).HasConversion(
                v => v.HasValue ? v.Value.ToString("yyyy-MM-dd") : null,
                v => v != null ? DateOnly.Parse(v) : (DateOnly?)null);
            e.Property(x => x.DischargeDate).HasConversion(
                v => v.HasValue ? v.Value.ToString("yyyy-MM-dd") : null,
                v => v != null ? DateOnly.Parse(v) : (DateOnly?)null);
            e.Ignore(x => x.ConditionName);
            e.Ignore(x => x.DoctorName);
            e.Ignore(x => x.FacilityName);
        });

        // ── Medical Tests ─────────────────────────────────────────────────
        mb.Entity<MedicalTest>(e =>
        {
            e.ToTable("tblTests");
            e.HasKey(x => x.TestsId);
            e.Property(x => x.TestDate).HasConversion(
                v => v.HasValue ? v.Value.ToString("yyyy-MM-dd") : null,
                v => v != null ? DateOnly.Parse(v) : (DateOnly?)null);
            e.Ignore(x => x.TestTypeName);
            e.Ignore(x => x.DoctorName);
            e.Ignore(x => x.FacilityName);
            e.Ignore(x => x.ConditionName);
        });

        // ── Family History ────────────────────────────────────────────────
        mb.Entity<FamilyHistory>(e =>
        {
            e.ToTable("tblFamilyHistories");
            e.HasKey(x => x.FamilyHistoryId);
            e.Ignore(x => x.Member);
            e.Ignore(x => x.Conditions);
        });

        mb.Entity<FamilyMember>(e =>
        {
            e.ToTable("tblFamilyMembers");
            e.HasKey(x => x.FamilyMemberId);
            e.Property(x => x.DOB).HasConversion(
                v => v.HasValue ? v.Value.ToString("yyyy-MM-dd") : null,
                v => v != null ? DateOnly.Parse(v) : (DateOnly?)null);
            e.Property(x => x.DOD).HasConversion(
                v => v.HasValue ? v.Value.ToString("yyyy-MM-dd") : null,
                v => v != null ? DateOnly.Parse(v) : (DateOnly?)null);
            e.Ignore(x => x.FullName);
        });

        mb.Entity<FamilyMemberCondition>(e =>
        {
            e.ToTable("tblFamilyMemberMedicalConditions");
            e.HasKey(x => x.FamilyMemberMedicalConditionId);
            e.Ignore(x => x.ConditionName);
        });

    }
}
