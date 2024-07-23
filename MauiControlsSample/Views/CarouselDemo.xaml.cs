using MauiControlsSample.ViewModels;

namespace MauiControlsSample.Views;

public partial class CarouselDemo : ContentPage
{
	public CarouselDemo(CarouselDemoViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = _viewModel = viewModel;
    }

    private CarouselDemoViewModel _viewModel;
}