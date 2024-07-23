using MauiControlsSample.ViewModels;

namespace MauiControlsSample.Views
{
    public partial class BearDetailPage : ContentPage
    {
        public BearDetailPage()
        {
            InitializeComponent();
            BindingContext = new BearDetailViewModel();
        }
    }
}