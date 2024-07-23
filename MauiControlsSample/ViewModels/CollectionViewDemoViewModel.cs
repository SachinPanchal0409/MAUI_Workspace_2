using CommunityToolkit.Mvvm.ComponentModel;
using MauiControlsSample.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiControlsSample.ViewModels
{
    public partial class CollectionViewDemoViewModel : ObservableObject
    {
        public ObservableCollection<Item> Items { get; set; }

        public Item SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (SetProperty(ref _selectedItem, value))
                {
                    ItemSelectedCommand.Execute(_selectedItem);
                }
            }
        }

        public ICommand ItemSelectedCommand { get; }

        public CollectionViewDemoViewModel()
        {
            Items = new ObservableCollection<Item>
            {
                new Item { Id = 1, Name = "Item 1", Description = "This is the description for item 1." },
                new Item { Id = 2, Name = "Item 2", Description = "This is the description for item 2." },
                new Item { Id = 3, Name = "Item 3", Description = "This is the description for item 3." },
                new Item { Id = 4, Name = "Item 4", Description = "This is the description for item 4." },
                new Item { Id = 5, Name = "Item 5", Description = "This is the description for item 5." },
                new Item { Id = 6, Name = "Item 6", Description = "This is the description for item 6." },
                new Item { Id = 7, Name = "Item 7", Description = "This is the description for item 7." },
                new Item { Id = 8, Name = "Item 8", Description = "This is the description for item 8." },
                new Item { Id = 9, Name = "Item 9", Description = "This is the description for item 9." },
                new Item { Id = 10, Name = "Item 10", Description = "This is the description for item 10." },
                new Item { Id = 11, Name = "Item 11", Description = "This is the description for item 11." },
                new Item { Id = 12, Name = "Item 12", Description = "This is the description for item 12." }
            };

            ItemSelectedCommand = new Command<Item>(OnItemSelected);
        }

        private async void OnItemSelected(Item item)
        {
            var navigationParameters = new Dictionary<string, object>
            {
                { "Item", SelectedItem }
            };
            await Shell.Current.GoToAsync($"itemdetails", navigationParameters);
        }

        public void UpdateItem(Item updatedItem)
        {
            var itemToUpdate = Items.FirstOrDefault(item => item.Id == updatedItem.Id);
            if (itemToUpdate is not null)
            {
                int index = Items.IndexOf(itemToUpdate);
                itemToUpdate.Name = updatedItem.Name;
                itemToUpdate.Description = updatedItem.Description;
                Items[index] = itemToUpdate;
            }
        }

        private Item _selectedItem;
    }
}
