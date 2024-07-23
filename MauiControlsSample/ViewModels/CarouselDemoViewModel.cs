using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiControlsSample.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiControlsSample.ViewModels
{
    public partial class CarouselDemoViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool isRefreshing;

        public IntroScreenModel CurrentItem
        {
            get => _currentItem;
            set
            {
                if (SetProperty(ref _currentItem, value))
                {
                    ItemSelectedCommand.Execute(_currentItem);
                }
            }
        }

        public int Position
        {
            get => _position;
            set => SetProperty(ref _position, value);
        }

        public ICommand ItemSelectedCommand { get; }

        public ICommand TapCommand { get; }

        public ObservableCollection<IntroScreenModel> IntroScreens { get; set; } = new ObservableCollection<IntroScreenModel>();

        public CarouselDemoViewModel()
        {
            IntroScreens.Add(new IntroScreenModel 
            {
                IntroTitle = "Brown Bear",
                IntroDescription = "The brown bear is a bear that is found across much of northern Eurasia and North America. In North America the population of brown bears are often called grizzly bears. It is one of the largest living terrestrial members of the order Carnivora, rivaled in size only by its closest relative, the polar bear, which is much less variable in size and slightly larger on average. The brown bear's principal range includes parts of Russia, Central Asia, China, Canada, the United States, Scandinavia and the Carpathian region, especially Romania, Anatolia and the Caucasus. The brown bear is recognized as a national and state animal in several European countries.",
                IntroImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5d/Kamchatka_Brown_Bear_near_Dvuhyurtochnoe_on_2015-07-23.jpg/320px-Kamchatka_Brown_Bear_near_Dvuhyurtochnoe_on_2015-07-23.jpg"
            });

            IntroScreens.Add(new IntroScreenModel
            {
                IntroTitle = "Polar Bear",
                IntroDescription = "The polar bear is a hypercarnivorous bear whose native range lies largely within the Arctic Circle, encompassing the Arctic Ocean, its surrounding seas and surrounding land masses. It is a large bear, approximately the same size as the omnivorous Kodiak bear. A boar (adult male) weighs around 350–700 kg (772–1,543 lb), while a sow (adult female) is about half that size. Although it is the sister species of the brown bear, it has evolved to occupy a narrower ecological niche, with many body characteristics adapted for cold temperatures, for moving across snow, ice and open water, and for hunting seals, which make up most of its diet. Although most polar bears are born on land, they spend most of their time on the sea ice. Their scientific name means maritime bear and derives from this fact. Polar bears hunt their preferred food of seals from the edge of sea ice, often living off fat reserves when no sea ice is present. Because of their dependence on the sea ice, polar bears are classified as marine mammals.",
                IntroImage = "https://upload.wikimedia.org/wikipedia/commons/6/66/Polar_Bear_-_Alaska_%28cropped%29.jpg"
            });

            IntroScreens.Add(new IntroScreenModel
            {
                IntroTitle = "Giant Panda",
                IntroDescription = "The giant panda, also known as panda bear or simply panda, is a bear native to south central China. It is easily recognized by the large, distinctive black patches around its eyes, over the ears, and across its round body. The name giant panda is sometimes used to distinguish it from the unrelated red panda. Though it belongs to the order Carnivora, the giant panda's diet is over 99% bamboo. Giant pandas in the wild will occasionally eat other grasses, wild tubers, or even meat in the form of birds, rodents, or carrion. In captivity, they may receive honey, eggs, fish, yams, shrub leaves, oranges, or bananas along with specially prepared food.",
                IntroImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0f/Grosser_Panda.JPG/320px-Grosser_Panda.JPG"
            });

            ItemSelectedCommand = new Command<IntroScreenModel>(OnItemSelected);
            TapCommand = new Command<IntroScreenModel>(OnTapped);

            _timer = Application.Current.Dispatcher.CreateTimer();
            _timer.Interval = TimeSpan.FromSeconds(50);
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            await NextCommand.ExecuteAsync(null);
        }

        private async void OnTapped(IntroScreenModel item)
        {
            await Application.Current.MainPage.DisplayAlert("Tapped", item.IntroTitle, "OK");
        }

        private async void OnItemSelected(IntroScreenModel item)
        {

        }

        [RelayCommand]
        private void Refresh()
        {
            IsRefreshing = true;
            IntroScreens.ToList().ForEach(screen => screen.IsIntroDescriptionVisible = true);
            IsRefreshing = false;
        }

        [RelayCommand]
        private async Task Next()
        {
            if (Position < IntroScreens.Count - 1)
            {
                Position += 1;
            }
        }

        [RelayCommand]
        private void Previous()
        {
            if (Position > 0)
            {
                Position -= 1;
            }
        }

        private int _position;
        private readonly IDispatcherTimer _timer;
        private IntroScreenModel _currentItem;
    }
}
