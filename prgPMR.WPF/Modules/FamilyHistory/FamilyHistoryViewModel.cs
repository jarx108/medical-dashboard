using prgPMR.WPF.Core.Interfaces;
using prgPMR.WPF.Core.ViewModels;

namespace prgPMR.WPF.Modules.FamilyHistory;

public partial class FamilyHistoryViewModel : ListViewModelBase<object>
{
    public FamilyHistoryViewModel(INavigationService nav, IUserSessionService session)
        : base(nav, session) { }

    protected override async Task LoadAsync()
    {
        await ExecuteAsync(async () =>
        {
            // TODO: Inject and use IFamilyHistoryRepository when implemented
            await Task.CompletedTask;
            Items.Clear();
        });
    }
}
