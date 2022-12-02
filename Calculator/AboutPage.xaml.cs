namespace Calculator;
using System;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Windows.Input;

public partial class AboutPage : ContentPage
{
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
