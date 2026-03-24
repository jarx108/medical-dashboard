namespace prgPMR.WPF.Core.Interfaces;

/// <summary>
/// Implemented by ViewModels that need to know when they are navigated to.
/// NavigationService calls OnNavigatedTo() after activation.
/// </summary>
public interface INavigationAware
{
    void OnNavigatedTo(object? parameter);
}
