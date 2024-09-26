namespace MauiThemeLabelsVanish.Services.Theme;

public class ThemeService
{

    public static void LoadTheme(ThemeNames theme)
    {
        if (Application.Current == null)
            return;

        if (!MainThread.IsMainThread)
        {
            MainThread.BeginInvokeOnMainThread(() => LoadTheme(theme));
            return;
        }

        ResourceDictionary? themeDictionary = null;

        switch (theme)
        {
            case ThemeNames.Red:
                themeDictionary = new RedTheme();
                break;
            case ThemeNames.Default:
            default:
                themeDictionary = new DefaultTheme();
                break;
        }

        Application.Current.Resources.MergedDictionaries.Clear();
        Application.Current.Resources.MergedDictionaries.Add(themeDictionary);
    }
}
