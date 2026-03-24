using prgPMR.WPF.Core.Interfaces;
using prgPMR.WPF.Core.ViewModels;

namespace prgPMR.WPF.Modules.Surgeries;

public partial class SurgeriesViewModel : ListViewModelBase<object>
{
    public SurgeriesViewModel(INavigationService nav, IUserSessionService session)
        : base(nav, session) { }

    protected override async Task LoadAsync()
    {
        await ExecuteAsync(async () =>
        {
            // TODO: Inject and use ISurgeryRepository when implemented
            await Task.CompletedTask;
            Items.Clear();
        });
    }
}
