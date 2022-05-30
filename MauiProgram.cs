using Microsoft.AspNetCore.Components.WebView.Maui;
using MauiApp2.Data;
using MudBlazor.Services;
using Microsoft.EntityFrameworkCore;
using MauiApp2.Repositories;

namespace MauiApp2;

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
            });

        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "blogs.db3");
        builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlite($"Filename={dbPath}"), ServiceLifetime.Transient, ServiceLifetime.Transient);

        builder.Services.AddMauiBlazorWebView();
#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif

        builder.Services.AddMudServices();

        builder.Services.AddSingleton<WeatherForecastService>();

        builder.Services.AddSingleton<IMediaPicker>(MediaPicker.Default);
        builder.Services.AddSingleton<IFileSystem>(FileSystem.Current);
        builder.Services.AddTransient<LogRepository>();

        return builder.Build();
    }
}
