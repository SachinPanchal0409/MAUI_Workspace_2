using MauiControlsSample.ViewModels;

namespace MauiControlsSample.Views;

public partial class RatingBar : ContentPage
{
	public RatingBar(RatingBarViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = _viewModel = viewModel;
    }

    private RatingBarViewModel _viewModel;
}