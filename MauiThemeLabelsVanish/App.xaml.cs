using CommunityToolkit.Mvvm.Messaging;
using MauiThemeLabelsVanish.Services.Navigation;
using MauiThemeLabelsVanish.Services.Theme;

namespace MauiThemeLabelsVanish;

public partial class App : Application
{
    private readonly INavigationService navigationService;

    public App(INavigationService navigationService)
    {
        this.navigationService = navigationService;
        
        InitializeComponent();

        MainPage = new AppShell(navigationService);

        // Register what happens when the ThemeChangedMessage is received.
        WeakReferenceMessenger.Default.Register<ThemeChangedMessage>(this, (r, m) =>
        {
            Enum.TryParse(m.Value, out ThemeNames messageTheme);
            ThemeService.LoadTheme(messageTheme);
        });


        ThemeService.LoadTheme(ThemeNames.Default);

    }
}
