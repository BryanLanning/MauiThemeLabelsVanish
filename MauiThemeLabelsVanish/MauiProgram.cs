using CommunityToolkit.Maui;
using MauiThemeLabelsVanish.Services.Navigation;
using MauiThemeLabelsVanish.ViewModels;
using MauiThemeLabelsVanish.Views;
using Microsoft.Extensions.Logging;

namespace MauiThemeLabelsVanish;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .RegisterAppServices()
            .RegisterViewModels()
            .RegisterViews();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }


    public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<INavigationService, MauiNavigationService>();

        return mauiAppBuilder;
    }
    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddTransient<MainViewModel>();
        mauiAppBuilder.Services.AddTransient<ThemeSelectionViewModel>();

        return mauiAppBuilder;
    }
    public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddTransient<MainView>();
        mauiAppBuilder.Services.AddTransient<ThemeSelectionView>();

        return mauiAppBuilder;
    }
}
