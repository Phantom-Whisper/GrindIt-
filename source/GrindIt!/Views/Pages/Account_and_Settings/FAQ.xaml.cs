namespace GrindIt_.Views.Pages.Account_and_Settings;

public partial class FAQ : ContentPage
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