using prgPMR.WPF.Core.Interfaces;
using prgPMR.WPF.Core.Models;
using prgPMR.WPF.Core.ViewModels;

namespace prgPMR.WPF.Modules.Immunization;

public partial class ImmunizationViewModel : ListViewModelBase<ImmunizationSummary>
{
    private readonly IImmunizationRepository _repo;

    public ImmunizationViewModel(
        IImmunizationRepository repo,
        INavigationService      nav,
        IUserSessionService     session)
        : base(nav, session)
    {
        _repo = repo;
    }

    protected override async Task LoadAsync()
    {
        await ExecuteAsync(async () =>
        {
            var summaries = await _repo.GetSummariesAsync(_session.UserId);
            Items.Clear();
            foreach (var s in summaries)
                Items.Add(s);
            SelectedItem = null;
        });
    }

    protected override void Add()
        => _nav.NavigateTo<ImmunizationDetailViewModel, ImmunizationNavParam>(
               new ImmunizationNavParam(ImmunizationMode.Add));

    protected override void Edit()
    {
        if (SelectedItem is null) return;
        _nav.NavigateTo<ImmunizationDetailViewModel, ImmunizationNavParam>(
            new ImmunizationNavParam(ImmunizationMode.Edit, SelectedItem));
    }

    protected override async Task DeleteAsync()
    {
        if (SelectedItem is null) return;

        var confirm = System.Windows.MessageBox.Show(
            $"Delete all dose records for '{SelectedItem.VaccineName}'?",
            "Confirm Delete",
            System.Windows.MessageBoxButton.YesNo,
            System.Windows.MessageBoxImage.Warning);

        if (confirm != System.Windows.MessageBoxResult.Yes) return;

        await ExecuteAsync(async () =>
        {
            foreach (var dose in SelectedItem.Doses)
                await _repo.DeleteDoseAsync(dose.ImmunizationDetailsId);

            await LoadAsync();
        });
    }
}
