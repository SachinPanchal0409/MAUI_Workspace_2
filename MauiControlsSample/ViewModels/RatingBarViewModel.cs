using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiControlsSample.Constant;

namespace MauiControlsSample.ViewModels
{
    public partial class RatingBarViewModel : ObservableObject
    {
        [ObservableProperty]
        public string icon0;

        [ObservableProperty]
        public string icon1;

        [ObservableProperty]
        public string icon2;

        [ObservableProperty]
        public string icon3;

        [ObservableProperty]
        public string icon4;

        public RatingBarViewModel()
        {
            Icon0 = Icons.StarIcon;
            Icon1 = Icons.StarIcon;
            Icon2 = Icons.StarIcon;
            Icon3 = Icons.StarIcon;
            Icon4 = Icons.StarIcon;
        }

        [RelayCommand]
        private void Tap(string index)
        {
            if (int.TryParse(index, out int intIndex))
            {
                Icon0 = intIndex >= 0 ? Icons.HeartIcon : Icons.StarIcon;
                Icon1 = intIndex >= 1 ? Icons.HeartIcon : Icons.StarIcon;
                Icon2 = intIndex >= 2 ? Icons.HeartIcon : Icons.StarIcon;
                Icon3 = intIndex >= 3 ? Icons.HeartIcon : Icons.StarIcon;
                Icon4 = intIndex >= 4 ? Icons.HeartIcon : Icons.StarIcon;
            }
        }
    }
}
