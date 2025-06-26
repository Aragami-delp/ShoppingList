using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using ShoppingList.Model;

namespace ShoppingList.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] private string m_statusText = "StatusText!";
    [ObservableProperty] private ObservableCollection<ShoppingListItem> m_ListEntries = new();

    public MainViewModel()
    {
        m_ListEntries = [new ShoppingListItem(true, "First Item"), new ShoppingListItem(false, "Second Item"), new ShoppingListItem(false, "Third Item")];
    }
}