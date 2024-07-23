using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiControlsSample.Models
{
    public partial class Item : ObservableObject
    {
        public int Id { get; set; }
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        private string _name;
        private string _description;
    }
}
