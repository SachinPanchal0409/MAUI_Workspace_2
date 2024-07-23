using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiControlsSample.Models
{
    public class IntroScreenModel : ObservableObject
    {
        public string IntroTitle { get; set; }
        public string IntroImage { get; set; }
        public string IntroDescription { get; set; }
        public bool IsIntroDescriptionVisible
        {
            get => _isIntroDescriptionVisible;
            set => SetProperty(ref _isIntroDescriptionVisible, value);
        }

        private bool _isIntroDescriptionVisible;
    }
}
