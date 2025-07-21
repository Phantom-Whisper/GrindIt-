namespace GrindIt_.Pages.Account_and_Settings;

public partial class About
{
	public About()
	{
		InitializeComponent();
	}

    private void Return_Clicked(object sender, EventArgs e)
    {
	    Navigation.PopAsync();
    }
}