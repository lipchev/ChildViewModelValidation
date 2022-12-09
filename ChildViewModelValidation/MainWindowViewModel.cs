using System.Collections.ObjectModel;
using Catel.MVVM;

namespace ChildViewModelValidation;

internal class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        HideValidationResults = false; // all validation-errors are immediately exposed to the UI 
        Items = new ObservableCollection<MyModel>();
    }

    public ObservableCollection<MyModel> Items { get; set; }

    #region AddItem command

    private Command? _addItemCommand;

    /// <summary>
    ///     Gets the AddItem command.
    /// </summary>
    public Command AddItemCommand
    {
        get { return _addItemCommand ??= new Command(AddItem); }
    }

    /// <summary>
    ///     Method to invoke when the AddItem command is executed.
    /// </summary>
    private void AddItem()
    {
        Items.Add(new MyModel());
    }

    #endregion

    #region RemoveItem command

    private Command<MyModel?>? _removeItemCommand;

    /// <summary>
    ///     Gets the RemoveItem command.
    /// </summary>
    public Command<MyModel?> RemoveItemCommand
    {
        get { return _removeItemCommand ??= new Command<MyModel?>(RemoveItem, CanRemoveItem); }
    }

    /// <summary>
    ///     Method to invoke when the RemoveItem command is executed.
    /// </summary>
    private void RemoveItem(MyModel? item)
    {
        Items.Remove(item!);
        // Validate(true); // this wouldn't help because the view model is not yet removed
    }

    private bool CanRemoveItem(MyModel? item)
    {
        return item is not null;
    }

    #endregion

    #region Validate command

    private Command? _validateCommand;

    /// <summary>
    /// Gets the Validate command.
    /// </summary>
    public Command ValidateCommand
    {
        get { return _validateCommand ??= new Command(Validate); }
    }

    /// <summary>
    /// Method to invoke when the Validate command is executed.
    /// </summary>
    private void Validate()
    {
        Validate(true);
    }

    #endregion
    
}