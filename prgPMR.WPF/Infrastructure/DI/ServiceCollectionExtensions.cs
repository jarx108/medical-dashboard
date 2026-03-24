using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using prgPMR.WPF.Core.Interfaces;
using prgPMR.WPF.Core.Navigation;
using prgPMR.WPF.Core.Services;
using prgPMR.WPF.Data;
using prgPMR.WPF.Data.Repositories;
using prgPMR.WPF.Modules.Bloodwork;
using prgPMR.WPF.Modules.DoctorVisits;
using prgPMR.WPF.Modules.FamilyHistory;
using prgPMR.WPF.Modules.Hospitalizations;
using prgPMR.WPF.Modules.Immunization;
using prgPMR.WPF.Modules.Medications;
using prgPMR.WPF.Modules.Surgeries;
using prgPMR.WPF.Modules.Tests;
using prgPMR.WPF.Modules.UpdateUserInfo;
using prgPMR.WPF.Shell;

namespace prgPMR.WPF.Infrastructure.DI;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPmrServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // ── Database ─────────────────────────────────────────────────────
        services.AddDbContext<AppDbContext>(opts =>
            opts.UseSqlite(configuration.GetConnectionString("DefaultConnection")));

        // ── Core services (singletons — one instance for entire app) ──────
        services.AddSingleton<IUserSessionService, UserSessionService>();
        services.AddSingleton<INavigationService,  NavigationService>();

        // ── Repositories (scoped — one per navigation frame) ─────────────
        services.AddScoped<IImmunizationRepository, ImmunizationRepository>();
        services.AddScoped<ILookupRepository,        LookupRepository>();
        services.AddScoped<IUserRepository,          UserRepository>();

        // ── Shell ViewModels ──────────────────────────────────────────────
        services.AddSingleton<MainViewModel>();
        services.AddTransient<LoginViewModel>();

        // ── Module ViewModels (Transient — fresh instance each navigation) ─
        services.AddTransient<ImmunizationViewModel>();
        services.AddTransient<ImmunizationDetailViewModel>();
        services.AddTransient<MedicationsViewModel>();
        services.AddTransient<FamilyHistoryViewModel>();
        services.AddTransient<DoctorVisitsViewModel>();
        services.AddTransient<TestsViewModel>();
        services.AddTransient<BloodworkViewModel>();
        services.AddTransient<SurgeriesViewModel>();
        services.AddTransient<HospitalizationsViewModel>();
        services.AddTransient<UpdateUserInfoViewModel>();

        return services;
    }
}
