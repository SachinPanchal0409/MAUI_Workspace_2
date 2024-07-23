using MauiControlsSample.ViewModels;

namespace MauiControlsSample.Views;

public partial class ButtonsControl : ContentPage
{
	public ButtonsControl(ButtonsControlViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = _viewModel = viewModel;
    }
    private ButtonsControlViewModel _viewModel;
}