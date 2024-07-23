using MauiControlsSample.ViewModels;

namespace MauiControlsSample.Views;

public partial class BindableLayoutDemo : ContentPage
{
	public BindableLayoutDemo(BindableLayoutDemoViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = _viewModel = viewModel;
    }

    private BindableLayoutDemoViewModel _viewModel;
}