using prgPMR.WPF.Core.Interfaces;
using prgPMR.WPF.Core.Models;

namespace prgPMR.WPF.Core.Services;

/// <summary>
/// Singleton that holds the logged-in user for the session.
/// Injected into repositories (need UserId) and header ViewModel (display name).
/// </summary>
public class UserSessionService : IUserSessionService
{
    public User? CurrentUser { get; private set; }
    public int   UserId      => CurrentUser?.UserId ?? 0;
    public bool  IsLoggedIn  => CurrentUser is not null;

    public void SetUser(User user)   => CurrentUser = user;
    public void ClearUser()         => CurrentUser = null;
}
