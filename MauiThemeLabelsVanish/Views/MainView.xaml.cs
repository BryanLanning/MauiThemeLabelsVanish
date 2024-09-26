namespace MauiThemeLabelsVanish.Views;

public partial class MainView : ContentPage
{
    private readonly MainViewModel viewModel;
    public MainView(MainViewModel viewModel)
	{
        BindingContext = this.viewModel = viewModel;
        InitializeComponent();
	}
}