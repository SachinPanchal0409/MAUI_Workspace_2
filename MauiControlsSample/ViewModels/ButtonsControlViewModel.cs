using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiControlsSample.ViewModels
{
    public partial class ButtonsControlViewModel : ObservableObject
    {
        [RelayCommand]
        private void ButtonClick()
        {
            Application.Current.MainPage.DisplayAlert("Clicked!!!", "Primary button clicked", "OK");
        }
    }
}
