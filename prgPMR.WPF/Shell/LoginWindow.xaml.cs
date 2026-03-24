using System.Windows;

namespace prgPMR.WPF.Shell;

public partial class LoginWindow : Window
{
    public LoginWindow()
    {
        InitializeComponent();
    }

    // PasswordBox doesn't support two-way binding (by design — security).
    // We push the value into the ViewModel on each change instead.
    private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
    {
        if (DataContext is LoginViewModel vm)
            vm.Password = PasswordBox.Password;
    }
}
