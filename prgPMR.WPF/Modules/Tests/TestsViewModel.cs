using prgPMR.WPF.Core.Interfaces;
using prgPMR.WPF.Core.ViewModels;

namespace prgPMR.WPF.Modules.Tests;

public partial class TestsViewModel : ListViewModelBase<object>
{
    public TestsViewModel(INavigationService nav, IUserSessionService session)
        : base(nav, session) { }

    protected override async Task LoadAsync()
    {
        await ExecuteAsync(async () =>
        {
            // TODO: Inject and use ITestRepository when implemented
            await Task.CompletedTask;
            Items.Clear();
        });
    }
}
