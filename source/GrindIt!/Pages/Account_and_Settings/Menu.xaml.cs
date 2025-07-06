namespace GrindIt_.Pages.Account_and_Settings;

public partial class Menu
{
	public Menu()
	{
		InitializeComponent();
	}

    private void Theme_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Theme());
    }

    private void Profile_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Profile());
    }

    private void Preferences_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PreferencesPage());
    }

    private void FAQ_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FAQ());
    }

    private void About_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new About());
    }

    private void Exit_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Account");
    }
}