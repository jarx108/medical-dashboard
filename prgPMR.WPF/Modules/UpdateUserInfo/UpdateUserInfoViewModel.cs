using prgPMR.WPF.Core.Interfaces;
using prgPMR.WPF.Core.ViewModels;

namespace prgPMR.WPF.Modules.UpdateUserInfo;

public partial class UpdateUserInfoViewModel : ListViewModelBase<object>
{
    public UpdateUserInfoViewModel(INavigationService nav, IUserSessionService session)
        : base(nav, session) { }

    protected override async Task LoadAsync()
    {
        await ExecuteAsync(async () =>
        {
            // TODO: Inject and use IUserInfoRepository when implemented
            await Task.CompletedTask;
            Items.Clear();
        });
    }
}
