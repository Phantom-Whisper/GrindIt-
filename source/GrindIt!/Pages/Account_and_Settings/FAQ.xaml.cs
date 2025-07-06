namespace GrindIt_.Pages.Account_and_Settings;

public partial class FAQ
{
	public FAQ()
	{
		InitializeComponent();
	}

    private void Return_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Menu");
    }
}