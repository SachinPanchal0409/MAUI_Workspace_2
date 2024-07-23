using MauiControlsSample.ViewModels;

namespace MauiControlsSample.Views;

public partial class CollectionViewDetail : ContentPage
{
	public CollectionViewDetail(CollectionViewDetailViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = _viewModel = viewModel;
    }

    private CollectionViewDetailViewModel _viewModel;
}