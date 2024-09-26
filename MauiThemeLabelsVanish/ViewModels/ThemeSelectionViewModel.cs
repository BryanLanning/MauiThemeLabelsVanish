using CommunityToolkit.Mvvm.ComponentModel;

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
