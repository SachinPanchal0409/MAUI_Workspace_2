using MauiControlsSample.ViewModels;

namespace MauiControlsSample.Views;

public partial class MonkeysPage : ContentPage
{
	public MonkeysPage()
	{
		InitializeComponent();
        BindingContext = new MonkeysPageViewModel();
    }
}