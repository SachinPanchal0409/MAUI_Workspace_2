using CommunityToolkit.Mvvm.ComponentModel;
using MauiControlsSample.Models;

namespace MauiControlsSample.ViewModels
{
    public class MonkeyDetailViewModel : ObservableObject, IQueryAttributable
    {
        public Animal Monkey { get; private set; }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            Monkey = query["Monkey"] as Animal;
            OnPropertyChanged("Monkey");
        }
    }
}
