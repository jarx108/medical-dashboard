using prgPMR.WPF.Core.Interfaces;
using prgPMR.WPF.Core.ViewModels;

namespace prgPMR.WPF.Modules.DoctorVisits;

public partial class DoctorVisitsViewModel : ListViewModelBase<object>
{
    public DoctorVisitsViewModel(INavigationService nav, IUserSessionService session)
        : base(nav, session) { }

    protected override async Task LoadAsync()
    {
        await ExecuteAsync(async () =>
        {
            // TODO: Inject and use IDoctorVisitRepository when implemented
            await Task.CompletedTask;
            Items.Clear();
        });
    }
}
