namespace MauiThemeLabelsVanish.Services.Navigation;

public class MauiNavigationService : INavigationService
{
    public MauiNavigationService()
    {
        
    }

    public async Task InitializeAsync()
    {
        await NavigateToAsync("Login");
    }

    public Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null)
    {
        throw new NotImplementedException();
    }

    public Task PopAsync()
    {
        throw new NotImplementedException();
    }

    public Task PopToRootAsync()
    {
        throw new NotImplementedException();
    }
}
