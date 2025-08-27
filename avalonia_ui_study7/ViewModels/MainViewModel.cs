using CommunityToolkit.Mvvm.ComponentModel;

namespace avalonia_ui_study7.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _greeting = "Welcome to Avalonia!";
}
