﻿using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using Application = Microsoft.Maui.Controls.Application;
using NavigationPage = Microsoft.Maui.Controls.NavigationPage;

namespace darkmode;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnModalPage(object sender, EventArgs e)
	{
		var modalPage = new NavigationPage(new MainPage() { Title = "Modal Page" });
		modalPage.On<iOS>().SetModalPresentationStyle(UIModalPresentationStyle.PageSheet);
		Navigation.PushModalAsync(modalPage);
	}

	private void OnDarkTheme(object sender, EventArgs e)
	{
		Application.Current!.UserAppTheme = AppTheme.Dark;
	}

	private void OnLightTheme(object sender, EventArgs e)
	{
		Application.Current!.UserAppTheme = AppTheme.Light;
	}

	private void OnResetTheme(object sender, EventArgs e)
	{
		Application.Current!.UserAppTheme = AppTheme.Unspecified;
	}
}

