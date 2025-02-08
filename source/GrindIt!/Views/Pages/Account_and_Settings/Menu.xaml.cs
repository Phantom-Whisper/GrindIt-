namespace GrindIt_.Views.Pages;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private void Theme_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("//ThemeView");
    }

    private void Profile_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Profile");
    }

    private void Preferences_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Preferences");
    }

    private void FAQ_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//FAQ");
    }

    private void About_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//About");
    }

    private void Exit_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//AccountView");
    }
}