using prgPMR.WPF.Core.Models;

namespace prgPMR.WPF.Core.Interfaces;

/// <summary>
/// Holds the currently-logged-in user for the lifetime of the session.
/// Injected wherever a UserId is needed (repositories, ViewModels).
/// </summary>
public interface IUserSessionService
{
    User?  CurrentUser { get; }
    int    UserId      { get; }
    bool   IsLoggedIn  { get; }

    void SetUser(User user);
    void ClearUser();
}
