using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace AvaloniaDynamicMenuTest.ViewModels;
public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<string> _recentFiles = new()
    {
        "test.txt",
        "sample.jpg",
        "something.cs"
    };

    [ObservableProperty] private string? _selectedFile;

    [RelayCommand]
    public void OpenRecentFileWithString(string name)
    {
        SelectedFile = name;
    }

    [RelayCommand]
    public void OpenRecentFileWithObject(object name)
    {
        SelectedFile = (string)name;
    }

    public void OpenRecentFileWithStringMethod(string name)
    {
        SelectedFile = name;
    }

    public void OpenRecentFileWithObjectMethod(object name)
    {
        SelectedFile = (string)name;
    }
}
