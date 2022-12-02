namespace Calculator;
using System;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Windows.Input;

public partial class AboutPage : ContentPage
{
    public Microsoft.Maui.FontWeight Weight { get; }

    public enum FontWeight
	{
		Black = 900,
		Bold = 700,
		Heavy = 800,
		Light = 300,
		Medium = 500,
		Regular = 400,
		Semibold = 600,
		Thin = 100,
		Ultralight = 200
	}

    private async void OnLearnMoreClicked(object sender, EventArgs e)
	{
		try
		{
			Uri uri = new Uri("https://www.starbucks.com/about-us/");
			await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
		}
		catch (Exception ex)
		{ //Error occured
		}
	}
    public AboutPage()
	{
		InitializeComponent();
	}
}
