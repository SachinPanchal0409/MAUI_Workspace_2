using MauiControlsSample.ViewModels;

namespace MauiControlsSample.Views;

public partial class NotificationDemo : ContentPage
{
	public NotificationDemo(NotificationDemoViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = _viewModel = viewModel;
    }

    private NotificationDemoViewModel _viewModel;
}