namespace GrindIt_.Pages.Account_and_Settings;

public partial class About
{
	public About()
	{
		InitializeComponent();
		
		GetVersioning();
	}

	/**
	 * Get the current versioning off the app
	 */
	private void GetVersioning()
	{
		var version = AppInfo.Current.Version;
		
		AppVersioningLabel.Text = $"Version {version}";
	}

	/**
	 * Navigate back to the menu
	 */
    private void Return_Clicked(object sender, EventArgs e)
    {
	    Navigation.PopAsync();
    }
}