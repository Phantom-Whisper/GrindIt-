namespace GrindIt_.Pages.Nutrition_Pages;

public partial class BodyComposition
{
	public BodyComposition()
	{
		InitializeComponent();
	}

    private void Return_Clicked(object sender, EventArgs e)
    {
	    Navigation.PopAsync();
    }
}