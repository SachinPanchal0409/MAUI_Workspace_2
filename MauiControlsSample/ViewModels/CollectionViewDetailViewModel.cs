using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiControlsSample.Models;

namespace MauiControlsSample.ViewModels
{
    public partial class CollectionViewDetailViewModel : ObservableObject, IQueryAttributable
    {
        public CollectionViewDetailViewModel(CollectionViewDemoViewModel collectionViewDemoViewModel)
        {
            _collectionViewDemoViewModel = collectionViewDemoViewModel;
        }
        public Item Item { get; private set; }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            Item = query["Item"] as Item;
            OnPropertyChanged("Item");
        }

        [RelayCommand]
        private async void Save()
        {
            if (Item is not null)
            {
                _collectionViewDemoViewModel.UpdateItem(Item);
                await Shell.Current.GoToAsync("..");
            }
        }

        private readonly CollectionViewDemoViewModel _collectionViewDemoViewModel;
    }
}
