namespace prgPMR.WPF.Core.Interfaces;

/// <summary>
/// Drives the main content area.
/// ViewModels call this instead of knowing about each other.
/// Replaces ControlManager's NavigateForward / NavigateBack.
/// </summary>
public interface INavigationService
{
    /// <summary>Navigate to a ViewModel with no parameter.</summary>
    void NavigateTo<TViewModel>() where TViewModel : class;

    /// <summary>Navigate to a ViewModel passing a typed parameter.</summary>
    void NavigateTo<TViewModel, TParam>(TParam parameter) where TViewModel : class;

    /// <summary>Return to the previous ViewModel on the back stack.</summary>
    void GoBack();

    /// <summary>True when there is something to go back to.</summary>
    bool CanGoBack { get; }

    /// <summary>Fired when the active ViewModel changes — MainViewModel subscribes.</summary>
    event EventHandler<object?> CurrentViewModelChanged;

    object? CurrentViewModel { get; }
}
