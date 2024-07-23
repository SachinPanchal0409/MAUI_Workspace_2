using MauiControlsSample.ViewModels;

namespace MauiControlsSample.Views;

public partial class MonkeyDetailPage : ContentPage
{
	public MonkeyDetailPage()
	{
		InitializeComponent();
        BindingContext = new MonkeyDetailViewModel();
    }
}