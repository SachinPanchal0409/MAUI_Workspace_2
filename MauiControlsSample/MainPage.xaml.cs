using MauiControlsSample.ViewModels;

namespace MauiControlsSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = _viewModel = viewModel;
        }

        private MainPageViewModel _viewModel;
    }
}
