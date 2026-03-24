using CommunityToolkit.Mvvm.ComponentModel;

namespace prgPMR.WPF.Core.ViewModels;

/// <summary>
/// Base class for all ViewModels.
/// CommunityToolkit.Mvvm's ObservableObject provides INotifyPropertyChanged
/// and the [ObservableProperty] / [RelayCommand] source generator attributes.
///
/// Adds common state: IsBusy (loading spinner), ErrorMessage.
/// </summary>
public abstract class ViewModelBase : ObservableObject
{
    private bool   _isBusy;
    private string _errorMessage = string.Empty;

    /// <summary>True while an async data operation is running — bind to a loading overlay.</summary>
    public bool IsBusy
    {
        get => _isBusy;
        protected set => SetProperty(ref _isBusy, value);
    }

    /// <summary>Non-empty when an operation fails — bind to an error banner.</summary>
    public string ErrorMessage
    {
        get => _errorMessage;
        protected set
        {
            if (SetProperty(ref _errorMessage, value))
                OnPropertyChanged(nameof(HasError));   // banner visibility depends on this
        }
    }

    public bool HasError => !string.IsNullOrEmpty(ErrorMessage);

    /// <summary>Run an async operation with IsBusy + error capture.</summary>
    protected async Task ExecuteAsync(Func<Task> operation)
    {
        IsBusy       = true;
        ErrorMessage = string.Empty;
        try
        {
            await operation();
        }
        catch (Exception ex)
        {
            ErrorMessage = ex.Message;
        }
        finally
        {
            IsBusy = false;
        }
    }
}
