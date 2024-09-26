namespace MauiThemeLabelsVanish.Services.Navigation;

public class MauiNavigationService : INavigationService
{
    public MauiNavigationService()
    {
        
    }

    public async Task InitializeAsync()
    {
        await NavigateToAsync(typeof(MainView).FullName!);
    }

    public Task NavigateToAsync(string route, IDictionary<string, object>? routeParameters = null)
    {
        if (routeParameters == null)
            return Shell.Current.GoToAsync(route);
        else
            return Shell.Current.GoToAsync(route, routeParameters);
    }

    public Task PopAsync()
    {
        return Shell.Current.GoToAsync("..");
    }

    public Task PopToRootAsync()
    {
        return Shell.Current.Navigation.PopToRootAsync();
    }
}
