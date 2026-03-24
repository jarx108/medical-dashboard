using CommunityToolkit.Mvvm.Input;
using prgPMR.WPF.Core.Interfaces;
using prgPMR.WPF.Core.Models;
using prgPMR.WPF.Core.Models.Lookups;
using prgPMR.WPF.Core.ViewModels;
using System.Collections.ObjectModel;

namespace prgPMR.WPF.Modules.Immunization;

/// <summary>
/// ViewModel for adding or editing an immunization dose record.
/// Replaces ImmunizationDetailControl — no ControlManager needed.
///
/// Each field is an observable property; IsDirty tracks unsaved changes.
/// Save/Cancel/Delete/Reset are typed ICommand properties — the View
/// binds to them with no extra wiring.
/// </summary>
public partial class ImmunizationDetailViewModel : ViewModelBase, INavigationAware
{
    private readonly IImmunizationRepository _repo;
    private readonly ILookupRepository       _lookups;
    private readonly INavigationService      _nav;
    private readonly IUserSessionService     _session;

    // ── Mode ──────────────────────────────────────────────────────────────
    public bool IsAddMode  { get; private set; }
    public bool IsEditMode => !IsAddMode;

    private ImmunizationDetail? _originalDetail;

    // ── Lookup lists (ComboBox sources) ───────────────────────────────────
    public ObservableCollection<VaccineName> VaccineNames  { get; } = [];
    public ObservableCollection<Facility>    Facilities    { get; } = [];
    public ObservableCollection<LookupItem>  Manufacturers { get; } = [];

    // ── Form fields ───────────────────────────────────────────────────────
    private VaccineName? _selectedVaccine;
    public VaccineName? SelectedVaccine
    {
        get => _selectedVaccine;
        set { SetProperty(ref _selectedVaccine, value); MarkDirty(); }
    }

    private string _detailName = string.Empty;
    public string DetailName
    {
        get => _detailName;
        set { SetProperty(ref _detailName, value); MarkDirty(); }
    }

    private DateOnly _dateGiven = DateOnly.FromDateTime(DateTime.Today);
    public DateOnly DateGiven
    {
        get => _dateGiven;
        set { SetProperty(ref _dateGiven, value); MarkDirty(); }
    }

    // DatePicker in WPF works with DateTime — expose a bridge property
    public DateTime DateGivenDateTime
    {
        get => DateGiven.ToDateTime(TimeOnly.MinValue);
        set { DateGiven = DateOnly.FromDateTime(value); }
    }

    private Facility? _selectedFacility;
    public Facility? SelectedFacility
    {
        get => _selectedFacility;
        set { SetProperty(ref _selectedFacility, value); MarkDirty(); }
    }

    private LookupItem? _selectedManufacturer;
    public LookupItem? SelectedManufacturer
    {
        get => _selectedManufacturer;
        set { SetProperty(ref _selectedManufacturer, value); MarkDirty(); }
    }

    private string _rxNum   = string.Empty;
    private string _ndcNum  = string.Empty;
    private string _lotNum  = string.Empty;
    private string _notes   = string.Empty;

    public string RxNum  { get => _rxNum;  set { SetProperty(ref _rxNum,  value); MarkDirty(); } }
    public string NdcNum { get => _ndcNum; set { SetProperty(ref _ndcNum, value); MarkDirty(); } }
    public string LotNum { get => _lotNum; set { SetProperty(ref _lotNum, value); MarkDirty(); } }
    public string Notes  { get => _notes;  set { SetProperty(ref _notes,  value); MarkDirty(); } }

    // ── Dirty tracking ────────────────────────────────────────────────────
    private bool _isDirty;
    private bool _initialising = true; // Suppress dirty during field population

    public bool IsDirty
    {
        get => _isDirty;
        private set => SetProperty(ref _isDirty, value);
    }

    private void MarkDirty()
    {
        if (!_initialising)
            IsDirty = true;
    }

    // ── Constructor ───────────────────────────────────────────────────────
    public ImmunizationDetailViewModel(
        IImmunizationRepository repo,
        ILookupRepository       lookups,
        INavigationService      nav,
        IUserSessionService     session)
    {
        _repo    = repo;
        _lookups = lookups;
        _nav     = nav;
        _session = session;
    }

    // ── Lifecycle ─────────────────────────────────────────────────────────

    public void OnNavigatedTo(object? parameter)
    {
        if (parameter is not ImmunizationNavParam p)
            throw new ArgumentException("ImmunizationDetailViewModel requires ImmunizationNavParam.");

        IsAddMode = p.Mode == ImmunizationMode.Add;
        OnPropertyChanged(nameof(IsAddMode));
        OnPropertyChanged(nameof(IsEditMode));

        _ = InitialiseAsync(p);
    }

    private async Task InitialiseAsync(ImmunizationNavParam p)
    {
        await ExecuteAsync(async () =>
        {
            // Load lookups first
            var vaccines      = await _lookups.GetVaccineNamesAsync();
            var facilities    = await _lookups.GetFacilitiesAsync();
            var manufacturers = await _lookups.GetManufacturersAsync();

            VaccineNames.Clear();
            foreach (var v in vaccines)      VaccineNames.Add(v);
            Facilities.Clear();
            foreach (var f in facilities)    Facilities.Add(f);
            Manufacturers.Clear();
            foreach (var m in manufacturers) Manufacturers.Add(m);

            _initialising = true;
            IsDirty = false;

            if (p.Mode == ImmunizationMode.Edit && p.Summary?.Doses.Count > 0)
            {
                // Load first dose for editing
                var dose = p.Summary.Doses[0];
                _originalDetail     = dose;
                SelectedVaccine     = VaccineNames.FirstOrDefault(v => v.Id == dose.SelectVaccineNameId);
                DetailName          = dose.DetailName    ?? string.Empty;
                DateGiven           = dose.DateGiven;
                SelectedFacility    = Facilities.FirstOrDefault(f => f.Id == dose.SelectFacilityId);
                SelectedManufacturer= Manufacturers.FirstOrDefault(m => m.Id == dose.SelectManufacturerId);
                RxNum               = dose.RxNum  ?? string.Empty;
                NdcNum              = dose.NdcNum  ?? string.Empty;
                LotNum              = dose.LotNum  ?? string.Empty;
                Notes               = dose.Notes   ?? string.Empty;
            }
            else
            {
                ClearFields();
            }

            _initialising = false;
        });
    }

    // ── Commands ──────────────────────────────────────────────────────────

    [RelayCommand]
    private async Task SaveAsync()
    {
        if (SelectedVaccine is null)
        {
            ErrorMessage = "Please select a vaccine name.";
            return;
        }

        await ExecuteAsync(async () =>
        {
            var detail = new ImmunizationDetail
            {
                ImmunizationDetailsId = _originalDetail?.ImmunizationDetailsId ?? 0,
                UserId               = _session.UserId,
                SelectVaccineNameId  = SelectedVaccine.Id,
                DetailName           = DetailName,
                DateGiven            = DateGiven,
                SelectFacilityId     = SelectedFacility?.Id,
                SelectManufacturerId = SelectedManufacturer?.Id,
                RxNum                = RxNum,
                NdcNum               = NdcNum,
                LotNum               = LotNum,
                Notes                = Notes
            };

            if (IsAddMode)
                await _repo.AddDoseAsync(detail);
            else
                await _repo.UpdateDoseAsync(detail);

            IsDirty = false;
            _nav.GoBack();
        });
    }

    [RelayCommand]
    private async Task DeleteAsync()
    {
        if (_originalDetail is null) return;

        var confirm = System.Windows.MessageBox.Show(
            "Delete this dose record permanently?",
            "Confirm Delete",
            System.Windows.MessageBoxButton.YesNo,
            System.Windows.MessageBoxImage.Warning);

        if (confirm != System.Windows.MessageBoxResult.Yes) return;

        await ExecuteAsync(async () =>
        {
            await _repo.DeleteDoseAsync(_originalDetail.ImmunizationDetailsId);
            IsDirty = false;
            _nav.GoBack();
        });
    }

    [RelayCommand]
    private void Reset()
    {
        if (IsDirty)
        {
            var confirm = System.Windows.MessageBox.Show(
                "Discard all changes and reset the form?",
                "Confirm Reset",
                System.Windows.MessageBoxButton.YesNo,
                System.Windows.MessageBoxImage.Question);

            if (confirm != System.Windows.MessageBoxResult.Yes) return;
        }

        _initialising = true;
        ClearFields();
        _initialising = false;
        IsDirty = false;
    }

    [RelayCommand]
    private void Cancel()
    {
        if (IsDirty)
        {
            var confirm = System.Windows.MessageBox.Show(
                "You have unsaved changes. Cancel anyway?",
                "Confirm Cancel",
                System.Windows.MessageBoxButton.YesNo,
                System.Windows.MessageBoxImage.Question);

            if (confirm != System.Windows.MessageBoxResult.Yes) return;
        }

        _nav.GoBack();
    }

    // ── Helpers ───────────────────────────────────────────────────────────

    private void ClearFields()
    {
        SelectedVaccine      = null;
        DetailName           = string.Empty;
        DateGiven            = DateOnly.FromDateTime(DateTime.Today);
        SelectedFacility     = null;
        SelectedManufacturer = null;
        RxNum                = string.Empty;
        NdcNum               = string.Empty;
        LotNum               = string.Empty;
        Notes                = string.Empty;
    }
}
