using CommunityToolkit.Mvvm.ComponentModel;
using MauiControlsSample.Models;

namespace MauiControlsSample.ViewModels
{
    public class BearDetailViewModel : ObservableObject, IQueryAttributable
    {
        public Animal Bear { get; private set; }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            Bear = query["Bear"] as Animal;
            OnPropertyChanged("Bear");
        }
    }
}
