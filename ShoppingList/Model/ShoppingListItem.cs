using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ShoppingList.Model;

public partial class ShoppingListItem(bool isFinished, string name) : ObservableObject
{
    [ObservableProperty] private bool m_isFinished = isFinished;
    [ObservableProperty] private string m_name = name;
}