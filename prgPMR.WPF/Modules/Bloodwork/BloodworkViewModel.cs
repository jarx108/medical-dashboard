using prgPMR.WPF.Core.Interfaces;
using prgPMR.WPF.Core.ViewModels;

namespace prgPMR.WPF.Modules.Bloodwork;

public partial class BloodworkViewModel : ListViewModelBase<object>
{
    public BloodworkViewModel(INavigationService nav, IUserSessionService session)
        : base(nav, session) { }

    protected override async Task LoadAsync()
    {
        await ExecuteAsync(async () =>
        {
            // TODO: Inject and use IBloodworkRepository when implemented
            await Task.CompletedTask;
            Items.Clear();
        });
    }
}
