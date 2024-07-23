using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Timers;

namespace MauiControlsSample.ViewModels
{
    public partial class ProgressBarViewModel : ObservableObject
    {
        [ObservableProperty]
        public double progressValue;

        [ObservableProperty]
        public string progressText;

        public ProgressBarViewModel()
        {
            ProgressText = "0%";
        }

        [RelayCommand]
        private void StartProgress()
        {
            ProgressValue = 0;
            ProgressText = "0%";

            _timer = new System.Timers.Timer(100); 
            _timer.Elapsed += OnTimedEvent;
            _timer.Start();
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            ProgressValue += 0.01; 

            MainThread.BeginInvokeOnMainThread(() =>
            {
                ProgressText = $"{(int)(ProgressValue * 100)}%";

                if (ProgressValue >= 1)
                {
                    _timer.Stop();
                    _timer.Dispose();
                }
            });
        }

        private System.Timers.Timer _timer;
    }
}
