using MauiControlsSample.ViewModels;

namespace MauiControlsSample.Views;

public partial class RefreshViewDemo : ContentPage
{
	public RefreshViewDemo(RefreshViewDemoViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = _viewModel = viewModel;
    }

    private RefreshViewDemoViewModel _viewModel;
}