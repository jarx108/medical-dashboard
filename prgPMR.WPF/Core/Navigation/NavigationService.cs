using Microsoft.Extensions.DependencyInjection;
using prgPMR.WPF.Core.Interfaces;

namespace prgPMR.WPF.Core.Navigation;

/// <summary>
/// Manages the main content area ViewModel stack.
/// Replaces WinForms ControlManager — ViewModels never reference each other directly.
///
/// Uses IServiceScopeFactory so that each navigation gets its own DI scope,
/// giving every ViewModel a fresh DbContext and repositories.
/// This avoids the "captive dependency" problem where a Singleton (NavigationService)
/// tries to resolve Scoped services (DbContext, repositories) from the root provider.
///
/// Usage from a ViewModel:
///   _nav.NavigateTo&lt;ImmunizationDetailViewModel, ImmunizationNavParam&gt;(param);
///   _nav.GoBack();
/// </summary>
public class NavigationService : INavigationService
{
    private readonly IServiceScopeFactory _scopeFactory;

    // Back stack stores ViewModel types (not instances) so GoBack() always
    // resolves a fresh instance — ensuring the list reloads after a save/delete.
    private readonly Stack<Type> _backStack = new();

    // The scope for the currently active ViewModel.
    // Disposed when navigating away; a new scope is created for the next VM.
    private IServiceScope? _currentScope;

    public object? CurrentViewModel { get; private set; }
    public bool    CanGoBack        => _backStack.Count > 0;

    public event EventHandler<object?>? CurrentViewModelChanged;

    public NavigationService(IServiceScopeFactory scopeFactory)
    {
        _scopeFactory = scopeFactory;
    }

    public void NavigateTo<TViewModel>() where TViewModel : class
        => Navigate(typeof(TViewModel), null);

    public void NavigateTo<TViewModel, TParam>(TParam parameter) where TViewModel : class
        => Navigate(typeof(TViewModel), parameter);

    public void GoBack()
    {
        if (_backStack.Count == 0) return;

        var previousType = _backStack.Pop();

        // Dispose the current scope (Detail VM's DbContext), create fresh one for list VM.
        _currentScope?.Dispose();
        _currentScope = _scopeFactory.CreateScope();

        var vm = _currentScope.ServiceProvider.GetRequiredService(previousType);

        // null param on GoBack — list ViewModels treat null as "reload the grid"
        SetCurrent(vm, null);
    }

    private void Navigate(Type vmType, object? param)
    {
        // Push current VM's type onto back stack before navigating away.
        if (CurrentViewModel is not null)
            _backStack.Push(CurrentViewModel.GetType());

        // Dispose the outgoing scope; create a fresh one for the new VM.
        _currentScope?.Dispose();
        _currentScope = _scopeFactory.CreateScope();

        var vm = _currentScope.ServiceProvider.GetRequiredService(vmType);
        SetCurrent(vm, param);
    }

    private void SetCurrent(object viewModel, object? param)
    {
        CurrentViewModel = viewModel;
        CurrentViewModelChanged?.Invoke(this, viewModel);

        if (viewModel is INavigationAware aware)
            aware.OnNavigatedTo(param);
    }
}
