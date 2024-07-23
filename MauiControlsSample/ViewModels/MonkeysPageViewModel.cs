using CommunityToolkit.Mvvm.ComponentModel;
using MauiControlsSample.Models;
using System.Windows.Input;

namespace MauiControlsSample.ViewModels
{
    public partial class MonkeysPageViewModel : ObservableObject
    {
        public Animal SelectedMonkey
        {
            get => _selectedMonkey;
            set
            {
                if (SetProperty(ref _selectedMonkey, value))
                {
                    if (_selectedMonkey != null)
                    {
                        ItemSelectedCommand.Execute(_selectedMonkey);
                    }
                }
            }
        }

        public ICommand ItemSelectedCommand { get; }

        public MonkeysPageViewModel()
        {
            ItemSelectedCommand = new Command<Animal>(OnItemSelected);
        }

        private async void OnItemSelected(Animal item)
        {
            var navigationParameters = new Dictionary<string, object>
            {
                { "Monkey", SelectedMonkey }
            };
            await Shell.Current.GoToAsync($"monkeydetails", navigationParameters);
        }

        private Animal _selectedMonkey;
    }
}
