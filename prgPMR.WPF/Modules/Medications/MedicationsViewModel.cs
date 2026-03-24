using prgPMR.WPF.Core.Interfaces;
using prgPMR.WPF.Core.ViewModels;

namespace prgPMR.WPF.Modules.Medications;

public partial class MedicationsViewModel : ListViewModelBase<object>
{
    public MedicationsViewModel(INavigationService nav, IUserSessionService session)
        : base(nav, session) { }

    protected override async Task LoadAsync()
    {
        await ExecuteAsync(async () =>
        {
            // TODO: Inject and use IMedicationRepository when implemented
            await Task.CompletedTask;
            Items.Clear();
        });
    }
}
