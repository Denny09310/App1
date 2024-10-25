using App1.Http;
using BlazorBindings.Maui;
using MauiIcons.Material;
using Microsoft.Extensions.Logging;
using Refit;

namespace App1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiBlazorBindings()
                .UseMaterialMauiIcons()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            builder.Services.AddRefitClient<IDummyClient>()
                .ConfigureHttpClient(client => client.BaseAddress = new Uri("https://dummyjson.com"));

            return builder.Build();
        }
    }
}
