using CommunityToolkit.Maui;
using MauiNav4.Services;
using MauiNav4.ViewModels;
using Microsoft.Extensions.Logging;

namespace MauiNav4;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<ItemDetails>();

		builder.Services.AddSingleton<MainPageViewModel>();
		builder.Services.AddSingleton<ItemDetailsViewModel>();

		builder.Services.AddSingleton<IBookDataSource, BookDataSource>();

        return builder.Build();
	}
}
