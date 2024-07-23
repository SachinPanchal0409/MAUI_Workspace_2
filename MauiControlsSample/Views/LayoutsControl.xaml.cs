using MauiControlsSample.ViewModels;

namespace MauiControlsSample.Views;

public partial class LayoutsControl : ContentPage
{
	public LayoutsControl(LayoutsControlViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = _viewModel = viewModel;
    }

    private LayoutsControlViewModel _viewModel;
}