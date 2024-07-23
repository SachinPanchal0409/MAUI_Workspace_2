using MauiControlsSample.ViewModels;

namespace MauiControlsSample.Views;

public partial class CollectionViewDemo : ContentPage
{
	public CollectionViewDemo(CollectionViewDemoViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = _viewModel = viewModel;
    }

    private CollectionViewDemoViewModel _viewModel;
}