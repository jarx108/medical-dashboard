using CommunityToolkit.Mvvm.Input;
using prgPMR.WPF.Core.Interfaces;
using prgPMR.WPF.Core.ViewModels;
using prgPMR.WPF.Data.Repositories;
using System.Windows;

namespace prgPMR.WPF.Shell;

public partial class LoginViewModel : ViewModelBase
{
    private readonly IUserRepository    _users;
    private readonly IUserSessionService _session;

    private string _username = string.Empty;
    private string _password = string.Empty;

    public string Username
    {
        get => _username;
        set => SetProperty(ref _username, value);
    }

    // Password is passed from code-behind (PasswordBox doesn't support binding for security)
    public string Password
    {
        get => _password;
        set => SetProperty(ref _password, value);
    }

    public LoginViewModel(IUserRepository users, IUserSessionService session)
    {
        _users   = users;
        _session = session;
    }

    [RelayCommand]
    private async Task LoginAsync()
    {
        if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
        {
            ErrorMessage = "Please enter both username and password.";
            return;
        }

        await ExecuteAsync(async () =>
        {
            var user = await _users.ValidateLoginAsync(Username.Trim(), Password.Trim());

            if (user is null)
            {
                ErrorMessage = "Incorrect username or password.";
                return;
            }

            _session.SetUser(user);

            // Open main window and close login window
            var mainWindow = new MainWindow
            {
                DataContext = App.GetService<MainViewModel>()
            };
            mainWindow.Show();

            Application.Current.Windows
                .OfType<LoginWindow>()
                .FirstOrDefault()
                ?.Close();
        });
    }

    [RelayCommand]
    private static void Exit() => Application.Current.Shutdown();
}
