using prgPMR.WPF.Core.Interfaces;
using prgPMR.WPF.Core.ViewModels;

namespace prgPMR.WPF.Modules.Hospitalizations;

public partial class HospitalizationsViewModel : ListViewModelBase<object>
{
    public HospitalizationsViewModel(INavigationService nav, IUserSessionService session)
        : base(nav, session) { }

    protected override async Task LoadAsync()
    {
        await ExecuteAsync(async () =>
        {
            // TODO: Inject and use IHospitalizationRepository when implemented
            await Task.CompletedTask;
            Items.Clear();
        });
    }
}
