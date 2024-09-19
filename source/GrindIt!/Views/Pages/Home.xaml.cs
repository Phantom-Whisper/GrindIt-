﻿namespace GrindIt_.Views.Pages;

public partial class Home : ContentPage
{
    int count = 0;

    public Home()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    private void OnBorderTapped(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync("//AccountView");
    }
}

