namespace GrindIt_.Pages.Nutrition_Pages;

public partial class Meal
{
	public Meal()
	{
		InitializeComponent();
	}

    private void Return_Clicked(object sender, EventArgs e)
    {
	    Navigation.PopAsync();
    }
}