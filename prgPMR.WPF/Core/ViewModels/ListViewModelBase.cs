using CommunityToolkit.Mvvm.Input;
using prgPMR.WPF.Core.Interfaces;
using System.Collections.ObjectModel;

namespace prgPMR.WPF.Core.ViewModels;

/// <summary>
/// Base class for list-style ViewModels that show a collection with
/// Add / Edit / Delete / Reset commands and a single selected item.
/// </summary>
public abstract partial class ListViewModelBase<TItem> : ViewModelBase, INavigationAware
{
    protected readonly INavigationService  _nav;
    protected readonly IUserSessionService _session;

    public ObservableCollection<TItem> Items { get; } = [];

    private TItem? _selectedItem;
    public TItem? SelectedItem
    {
        get => _selectedItem;
        set
        {
            SetProperty(ref _selectedItem, value);
            OnPropertyChanged(nameof(HasSelection));
            EditCommand.NotifyCanExecuteChanged();
            DeleteCommand.NotifyCanExecuteChanged();
        }
    }

    public bool HasSelection => SelectedItem is not null;

    protected ListViewModelBase(INavigationService nav, IUserSessionService session)
    {
        _nav     = nav;
        _session = session;
    }

    public void OnNavigatedTo(object? parameter) => _ = LoadAsync();

    protected abstract Task LoadAsync();

    [RelayCommand]
    protected virtual void Add() { }

    [RelayCommand(CanExecute = nameof(HasSelection))]
    protected virtual void Edit() { }

    [RelayCommand(CanExecute = nameof(HasSelection))]
    protected virtual async Task DeleteAsync() { await Task.CompletedTask; }

    [RelayCommand]
    protected virtual void Reset() => SelectedItem = default;
}
