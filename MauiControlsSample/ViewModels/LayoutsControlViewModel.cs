using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiControlsSample.Views;

namespace MauiControlsSample.ViewModels
{
    public partial class LayoutsControlViewModel : ObservableObject
    {
        [RelayCommand]
        private void StackLayout()
        {
            Shell.Current.GoToAsync(nameof(StackLayoutDemo));
        }

        [RelayCommand]
        private void Grid()
        {
            Shell.Current.GoToAsync(nameof(GridDemo));
        }

        [RelayCommand]
        private void FlexLayout()
        {
            Shell.Current.GoToAsync(nameof(FlexLayoutDemo));
        }

        [RelayCommand]
        private void AbsoluteLayout()
        {
            Shell.Current.GoToAsync(nameof(AbsoluteLayoutDemo));
        }

        [RelayCommand]
        private void CustomLayout()
        {
            Shell.Current.GoToAsync(nameof(ZStackLayoutPage));
        }


        [RelayCommand]
        private void BindableLayout()
        {
            Shell.Current.GoToAsync(nameof(BindableLayoutDemo));
        }
    }
}
