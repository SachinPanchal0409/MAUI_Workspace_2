using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using MauiControlsSample.Models;

namespace MauiControlsSample.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Item> items;

        public MainPageViewModel()
        {
            Items = new ObservableCollection<Item>
            {
                new Item { Name = "Shell", Description = "The visual hierarchy of the app is described in a class that subclasses the Shell class." }
            };
        }
    }
}
