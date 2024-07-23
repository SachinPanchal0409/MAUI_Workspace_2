using MauiControlsSample.ViewModels;

namespace MauiControlsSample.Views;

public partial class ProgressBarControl : ContentPage
{
	public ProgressBarControl(ProgressBarViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = _viewModel = viewModel;
    }

    private ProgressBarViewModel _viewModel;
}