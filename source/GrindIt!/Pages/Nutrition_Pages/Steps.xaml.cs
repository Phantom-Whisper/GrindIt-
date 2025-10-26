namespace GrindIt_.Pages.Nutrition_Pages;

public partial class Steps
{
	public Steps()
	{
		InitializeComponent();
	}

    private void Return_Clicked(object sender, EventArgs e)
    {
	    Navigation.PopAsync();
    }
}