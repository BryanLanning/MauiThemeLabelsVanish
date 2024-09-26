using MauiThemeLabelsVanish.Services;
using MauiThemeLabelsVanish.Views;

namespace MauiThemeLabelsVanish;

public partial class AppShell : Shell
{
    private readonly INavigationService navigationService;

    public AppShell(INavigationService navigationService)
    {
        this.navigationService = navigationService;
        AppShell.InitializeRouting();
        InitializeComponent();
    }
    private static void InitializeRouting()
    {
        //Routing.RegisterRoute(typeof(MainView).FullName!, typeof(MainView);
        Routing.RegisterRoute(typeof(ThemeSelectionView).FullName!, typeof(ThemeSelectionView));
    }

}
