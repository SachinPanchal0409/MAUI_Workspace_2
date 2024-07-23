using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using MauiControlsSample.Models;
using System.Windows.Input;
using MauiControlsSample.Views;

namespace MauiControlsSample.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Item> items;

        public Item SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (SetProperty(ref _selectedItem, value))
                {
                    if (_selectedItem != null)
                    {
                        ItemSelectedCommand.Execute(_selectedItem);
                    }
                }
            }
        }

        public ICommand ItemSelectedCommand { get; }

        public MainPageViewModel()
        {
            Items = new ObservableCollection<Item>
            {
                new Item { Name = "Shell", Description = "The visual hierarchy of the app is described in a class that subclasses the Shell class." },
                new Item { Name = "Layouts", Description = "The visual hierarchy of the app is described in a class that subclasses the Shell class." },
                new Item { Name = "RefreshView", Description = "The visual hierarchy of the app is described in a class that subclasses the Shell class." },
                new Item { Name = "ProgressBar", Description = "The visual hierarchy of the app is described in a class that subclasses the Shell class." },
                new Item { Name = "Button", Description = "The visual hierarchy of the app is described in a class that subclasses the Shell class." },
                new Item { Name = "CollectionView", Description = "The visual hierarchy of the app is described in a class that subclasses the Shell class." },
                new Item { Name = "ListView", Description = "The visual hierarchy of the app is described in a class that subclasses the Shell class." },
                new Item { Name = "TabView", Description = "The visual hierarchy of the app is described in a class that subclasses the Shell class." },
                new Item { Name = "CarouselView", Description = "The visual hierarchy of the app is described in a class that subclasses the Shell class." },
                new Item { Name = "RatingBar", Description = "The visual hierarchy of the app is described in a class that subclasses the Shell class." },
                new Item { Name = "Menu", Description = "The visual hierarchy of the app is described in a class that subclasses the Shell class." },
                new Item { Name = "Notification", Description = "The visual hierarchy of the app is described in a class that subclasses the Shell class." },
                new Item { Name = "Map", Description = "The visual hierarchy of the app is described in a class that subclasses the Shell class." }
            };
            ItemSelectedCommand = new Command<Item>(OnItemSelected);
        }

        private async void OnItemSelected(Item item)
        {
            if (item.Name == "Shell")
            {
                await Shell.Current.GoToAsync(nameof(ShellControl));
            }

            if (item.Name == "Layouts")
            {
                await Shell.Current.GoToAsync(nameof(LayoutsControl));
            }

            if (item.Name == "RefreshView")
            {
                await Shell.Current.GoToAsync(nameof(RefreshViewDemo));
            }

            if (item.Name == "ProgressBar")
            {
                await Shell.Current.GoToAsync(nameof(ProgressBarControl));
            }

            if (item.Name == "Button")
            {
                await Shell.Current.GoToAsync(nameof(ButtonsControl));
            }

            if (item.Name == "CollectionView")
            {
                await Shell.Current.GoToAsync(nameof(CollectionViewDemo));
            }

            if (item.Name == "ListView")
            {
                await Shell.Current.GoToAsync(nameof(ListViewDemo));
            }

            if (item.Name == "CarouselView")
            {
                await Shell.Current.GoToAsync(nameof(CarouselDemo));
            }

            if (item.Name == "RatingBar")
            {
                await Shell.Current.GoToAsync(nameof(RatingBar));
            }

            if (item.Name == "Menu")
            {
                await Shell.Current.GoToAsync(nameof(MenusDemo));
            }

            SelectedItem = null; 
        }

        private Item _selectedItem;
    }
}
