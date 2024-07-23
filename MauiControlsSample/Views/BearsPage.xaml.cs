using MauiControlsSample.ViewModels;

namespace MauiControlsSample.Views;

public partial class BearsPage : ContentPage
{
	public BearsPage()
	{
		InitializeComponent();
        BindingContext = new BearsPageViewModel();
    }
}