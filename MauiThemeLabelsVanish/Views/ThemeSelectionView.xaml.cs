using MauiThemeLabelsVanish.ViewModels;

namespace MauiThemeLabelsVanish.Views;

public partial class ThemeSelectionView : ContentPageBase
{
    private readonly ThemeSelectionViewModel viewModel;

    public ThemeSelectionView(ThemeSelectionViewModel viewModel)
	{
        BindingContext = this.viewModel = viewModel;
        InitializeComponent();
    }
}