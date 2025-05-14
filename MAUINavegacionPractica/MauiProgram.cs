using MAUINavegacionPractica.View;
using MAUINavegacionPractica.ViewModel;
using MAUINavegacionPractica.ViewModel.SharedService;
using Microsoft.Extensions.Logging;

namespace MAUINavegacionPractica
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });


            builder.Services.AddSingleton<ContactService>();
            builder.Services.AddTransient<MainPageViewModel>();
            builder.Services.AddTransient<PageOneViewModel>();

            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<PageOne>();


#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
