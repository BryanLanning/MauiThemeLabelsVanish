using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiThemeLabelsVanish.Services.Navigation;
using MauiThemeLabelsVanish.Services.Theme;

namespace MauiThemeLabelsVanish.ViewModels;

public partial class ThemeSelectionViewModel : ObservableObject
{
    public ThemeSelectionViewModel(INavigationService navigationService)
    {
        
    }

    [RelayCommand]
    private async Task ToggleTheme()
    {
        var mergedDictionaries = Application.Current!.Resources.MergedDictionaries.ToList();
        var firstDictionary = mergedDictionaries.First();

        if (firstDictionary.GetType().Name == "DefaultTheme")
            ThemeService.LoadTheme(ThemeNames.Red);
        else
            ThemeService.LoadTheme(ThemeNames.Default);

        return;
    }
}
