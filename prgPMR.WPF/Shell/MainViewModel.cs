using CommunityToolkit.Mvvm.Input;
using prgPMR.WPF.Core.Interfaces;
using prgPMR.WPF.Core.ViewModels;
using prgPMR.WPF.Modules.Bloodwork;
using prgPMR.WPF.Modules.DoctorVisits;
using prgPMR.WPF.Modules.FamilyHistory;
using prgPMR.WPF.Modules.Hospitalizations;
using prgPMR.WPF.Modules.Immunization;
using prgPMR.WPF.Modules.Medications;
using prgPMR.WPF.Modules.Surgeries;
using prgPMR.WPF.Modules.Tests;
using prgPMR.WPF.Modules.UpdateUserInfo;
using System.Windows;

namespace prgPMR.WPF.Shell;

/// <summary>
/// Root ViewModel — owns the navigation content area and the patient header.
/// The sidebar nav buttons call NavigateTo commands here.
/// MainWindow's ContentControl binds to CurrentViewModel; WPF DataTemplates
/// automatically pick the correct View with no switch statement anywhere.
/// </summary>
public partial class MainViewModel : ViewModelBase
{
    private readonly INavigationService  _nav;
    private readonly IUserSessionService _session;

    private object? _currentViewModel;

    public object? CurrentViewModel
    {
        get => _currentViewModel;
        private set => SetProperty(ref _currentViewModel, value);
    }

    // ── Patient header (bound in top bar) ────────────────────────────────
    public string PatientName => _session.CurrentUser?.FullName ?? string.Empty;
    public string PatientDob  => _session.CurrentUser?.DOB?.ToString("MM/dd/yyyy") ?? string.Empty;

    public MainViewModel(INavigationService nav, IUserSessionService session)
    {
        _nav     = nav;
        _session = session;

        // Subscribe to navigation changes → update CurrentViewModel
        _nav.CurrentViewModelChanged += (_, vm) => CurrentViewModel = vm;

        // Default to Immunization module on open
        NavigateToImmunization();
    }

    // ── Navigation commands ── one per module ────────────────────────────

    [RelayCommand] public void NavigateToImmunization()    => _nav.NavigateTo<ImmunizationViewModel>();
    [RelayCommand] public void NavigateToMedications()     => _nav.NavigateTo<MedicationsViewModel>();
    [RelayCommand] public void NavigateToFamilyHistory()   => _nav.NavigateTo<FamilyHistoryViewModel>();
    [RelayCommand] public void NavigateToDoctorVisits()    => _nav.NavigateTo<DoctorVisitsViewModel>();
    [RelayCommand] public void NavigateToTests()           => _nav.NavigateTo<TestsViewModel>();
    [RelayCommand] public void NavigateToBloodwork()       => _nav.NavigateTo<BloodworkViewModel>();
    [RelayCommand] public void NavigateToSurgeries()       => _nav.NavigateTo<SurgeriesViewModel>();
    [RelayCommand] public void NavigateToHospitalizations()=> _nav.NavigateTo<HospitalizationsViewModel>();
    [RelayCommand] public void NavigateToUpdateUserInfo()  => _nav.NavigateTo<UpdateUserInfoViewModel>();

    [RelayCommand]
    private static void Logout()
    {
        // Show login, close main
        var login = new LoginWindow { DataContext = App.GetService<LoginViewModel>() };
        login.Show();
        Application.Current.Windows.OfType<MainWindow>().FirstOrDefault()?.Close();
    }
}
