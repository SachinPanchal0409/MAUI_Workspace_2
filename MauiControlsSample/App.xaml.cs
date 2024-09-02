using MauiControlsSample.Views;

namespace MauiControlsSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent(); 
            Routing.RegisterRoute(nameof(ShellControl), typeof(ShellControl));
            Routing.RegisterRoute(nameof(LayoutsControl), typeof(LayoutsControl));
            Routing.RegisterRoute(nameof(StackLayoutDemo), typeof(StackLayoutDemo));
            Routing.RegisterRoute(nameof(AbsoluteLayoutDemo), typeof(AbsoluteLayoutDemo));
            Routing.RegisterRoute(nameof(FlexLayoutDemo), typeof(FlexLayoutDemo));
            Routing.RegisterRoute(nameof(GridDemo), typeof(GridDemo));
            Routing.RegisterRoute(nameof(BindableLayoutDemo), typeof(BindableLayoutDemo));
            Routing.RegisterRoute(nameof(RefreshViewDemo), typeof(RefreshViewDemo));
            Routing.RegisterRoute(nameof(ProgressBarControl), typeof(ProgressBarControl)); 
            Routing.RegisterRoute(nameof(ZStackLayoutPage), typeof(ZStackLayoutPage));
            Routing.RegisterRoute(nameof(ButtonsControl), typeof(ButtonsControl)); 
            Routing.RegisterRoute(nameof(CollectionViewDemo), typeof(CollectionViewDemo));
            Routing.RegisterRoute(nameof(ListViewDemo), typeof(ListViewDemo)); 
            Routing.RegisterRoute(nameof(CarouselDemo), typeof(CarouselDemo)); 
            Routing.RegisterRoute(nameof(RatingBar), typeof(RatingBar));
            Routing.RegisterRoute(nameof(MenusDemo), typeof(MenusDemo));
            Routing.RegisterRoute(nameof(NotificationDemo), typeof(NotificationDemo)); 
            MainPage = new AppShell();
        }
    }
}
