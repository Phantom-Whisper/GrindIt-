namespace GrindIt_.Pages.Account_and_Settings;

public partial class Profile
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