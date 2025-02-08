namespace GrindIt_.Views.Pages.Account_and_Settings;

public partial class Preferences : ContentPage
{
	public Preferences()
	{
		InitializeComponent();
	}

    private void Return_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Menu");
    }
}