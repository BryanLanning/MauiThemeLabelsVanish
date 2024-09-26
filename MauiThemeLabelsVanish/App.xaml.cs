using MauiThemeLabelsVanish.Services;

namespace MauiThemeLabelsVanish
{
    public partial class App : Application
    {
        private readonly INavigationService navigationService;

        public App(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            
            InitializeComponent();

            MainPage = new AppShell(navigationService);
        }
    }
}
