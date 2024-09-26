using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiThemeLabelsVanish.Services.Navigation;
using MauiThemeLabelsVanish.Views;

namespace MauiThemeLabelsVanish.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly INavigationService navigationService;

    public MainViewModel(INavigationService navigationService)
    {
        this.navigationService = navigationService;
    }

    [RelayCommand]
    private async Task GoToThemeView()
    {
        await navigationService.NavigateToAsync(typeof(ThemeSelectionView).FullName!);
    }
}
