using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Plugin.LocalNotification;
using Plugin.LocalNotification.EventArgs;

namespace MauiControlsSample.ViewModels
{
    public partial class NotificationDemoViewModel : ObservableObject
    {
        public NotificationDemoViewModel()
        {
            LocalNotificationCenter.Current.NotificationActionTapped += Current_NotificationActionTapped;
        }

        private void Current_NotificationActionTapped(NotificationActionEventArgs e)
        {
            if (e.IsDismissed)
            {

            }
            else if (e.IsTapped)
            {

            }
        }

        [RelayCommand]
        private async Task Notification()
        {
            if (await LocalNotificationCenter.Current.AreNotificationsEnabled() == false)
            {
                await LocalNotificationCenter.Current.RequestNotificationPermission();
            }
            var request = new NotificationRequest
            {
                NotificationId = 1337,
                Title = "Subcribe to my channel",
                Subtitle = "Hello",
                Description = "How are you?",
                BadgeNumber = 42,
                //CategoryType = NotificationCategoryType.Reminder,
                Schedule = new NotificationRequestSchedule
                {
                    NotifyTime = DateTime.Now.AddSeconds(5),
                    NotifyRepeatInterval = TimeSpan.FromDays(1)
                },
            };

            await LocalNotificationCenter.Current.Show(request);
        }
    }
}
