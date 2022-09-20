using ByeBills.ViewModels;
using ByeBills.Views;
using Microsoft.Extensions.DependencyInjection;

namespace ByeBills;

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

		builder.Services.AddSingleton<CategoriaPage>();
		builder.Services.AddSingleton<CategoriaViewModel>();

		builder.Services.AddSingleton<AddCategoriaPage>();
		builder.Services.AddSingleton<AddCategoriaViewModel>();

		return builder.Build();
	}
}
