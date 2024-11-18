using Microsoft.Extensions.Logging;

namespace MauiCadastroEventos
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
                    fonts.AddFont("Fascinate-Regular.ttf", "Fascinate");
                    fonts.AddFont("Kranky-Regular.ttf", "Kranky");
                    fonts.AddFont("YuseiMagic-Regular", "Yusei");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
