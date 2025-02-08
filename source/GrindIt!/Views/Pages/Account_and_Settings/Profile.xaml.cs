namespace GrindIt_.Views.Pages.Account_and_Settings;

public partial class Profile : ContentPage
{
	public Profile()
	{
		InitializeComponent();
	}

    private void Return_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Menu");
    }
}