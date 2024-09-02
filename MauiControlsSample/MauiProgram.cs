using MauiControlsSample.ViewModels;
using Microsoft.Extensions.Logging;
using MauiControlsSample.Views;
using Plugin.LocalNotification;

namespace MauiControlsSample
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseLocalNotification()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialIconsRegular");
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("FluentSystemIcons-Filled.ttf", "FluentIcons");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<MainPageViewModel>();
            builder.Services.AddTransient<LayoutsControl>();
            builder.Services.AddTransient<LayoutsControlViewModel>();
            builder.Services.AddTransient<BindableLayoutDemo>();
            builder.Services.AddTransient<BindableLayoutDemoViewModel>();
            builder.Services.AddTransient<RefreshViewDemo>();
            builder.Services.AddTransient<RefreshViewDemoViewModel>();
            builder.Services.AddTransient<ProgressBarControl>();
            builder.Services.AddTransient<ProgressBarViewModel>();
            builder.Services.AddTransient<ButtonsControl>();
            builder.Services.AddTransient<ButtonsControlViewModel>();
            builder.Services.AddTransient<CollectionViewDemo>();
            builder.Services.AddTransient<CollectionViewDemoViewModel>();
            builder.Services.AddTransient<CollectionViewDetail>(); 
            builder.Services.AddTransient<CollectionViewDetailViewModel>();
            builder.Services.AddTransient<ListViewDemo>();
            builder.Services.AddTransient<CarouselDemo>();
            builder.Services.AddTransient<CarouselDemoViewModel>();
            builder.Services.AddTransient<RatingBar>();
            builder.Services.AddTransient<RatingBarViewModel>();
            builder.Services.AddTransient<NotificationDemo>();
            builder.Services.AddTransient<NotificationDemoViewModel>();
            return builder.Build();
        }
    }
}
