using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiControlsSample.ViewModels
{
    public partial class RefreshViewDemoViewModel : ObservableObject
    {
        private int _refreshCount = 0;
        private readonly IDispatcherTimer _timer;

        [ObservableProperty]
        private ObservableCollection<string> items;

        [ObservableProperty]
        private bool isRefreshing;

        public RefreshViewDemoViewModel()
        {
            Items = new ObservableCollection<string>
            {
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5"
            };

            _timer = Application.Current.Dispatcher.CreateTimer();
            _timer.Interval = TimeSpan.FromSeconds(5);
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            await RefreshCommand.ExecuteAsync(null);
        }

        [RelayCommand]
        public async Task Refresh()
        {
            if (IsRefreshing)
            {
                return;
            }
            IsRefreshing = true;

            await Task.Delay(2000);

            _refreshCount++;
            await Application.Current.Dispatcher.DispatchAsync(() =>
            {
                Items.Clear();
                Items.Add($"{_refreshCount} Item A");
                Items.Add($"{_refreshCount} Item B");
                Items.Add($"{_refreshCount} Item C");
                Items.Add($"{_refreshCount} Item D");
                Items.Add($"{_refreshCount} Item E");
            });
            IsRefreshing = false;
        }
    }
}
