using CommunityToolkit.Mvvm.ComponentModel;
using MauiControlsSample.Models;
using System.Windows.Input;

namespace MauiControlsSample.ViewModels
{
    public partial class BearsPageViewModel : ObservableObject
    {
        public Animal SelectedBear
        {
            get => _selectedBear;
            set
            {
                if (SetProperty(ref _selectedBear, value))
                {
                    if (_selectedBear != null)
                    {
                        ItemSelectedCommand.Execute(_selectedBear);
                    }
                }
            }
        }

        public ICommand ItemSelectedCommand { get; }

        public BearsPageViewModel()
        {
            ItemSelectedCommand = new Command<Animal>(OnItemSelected);
        }

        private async void OnItemSelected(Animal item)
        {
            var navigationParameters = new Dictionary<string, object>
            {
                { "Bear", SelectedBear }
            };
            await Shell.Current.GoToAsync($"beardetails", navigationParameters);
        }

        private Animal _selectedBear;
    }
}
