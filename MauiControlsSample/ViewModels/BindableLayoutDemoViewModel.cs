using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using MauiControlsSample.Models;

namespace MauiControlsSample.ViewModels
{
    public partial class BindableLayoutDemoViewModel : ObservableObject
    {
        public ObservableCollection<Item> Items { get; set; }

        public BindableLayoutDemoViewModel()
        {
            Items = new ObservableCollection<Item>
            {
                new Item { Name = "Item 1", Description = "This is the description for item 1." },
                new Item { Name = "Item 2", Description = "This is the description for item 2." },
                new Item { Name = "Item 3", Description = "This is the description for item 3." }
            };
        }
    }
}
