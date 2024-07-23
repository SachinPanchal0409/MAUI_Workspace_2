using MauiControlsSample.ViewModels;

namespace MauiControlsSample.Views;

public partial class ListViewDemo : ContentPage
{
	public ListViewDemo(CollectionViewDemoViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = _viewModel = viewModel;
    }

    private CollectionViewDemoViewModel _viewModel;
}