namespace Calculator;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
        builder.Services.AddSingleton<HistoryViewModel>();
		builder.Services
			.AddSingleton<MainPage>()
			.AddSingleton<History>()
			.AddSingleton<HistoryViewModel>()
			.AddSingleton<HistoryDB>()
			.AddSingleton<HistoryData>();
			

            
        builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("HelveticaLTStd-Blk.otf", "Helvetica");
			});
		
		return builder.Build();
	}
}

