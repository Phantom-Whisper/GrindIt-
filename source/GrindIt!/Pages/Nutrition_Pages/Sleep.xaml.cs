namespace GrindIt_.Pages.Nutrition_Pages;

public partial class Sleep : ContentPage
{
	public Sleep()
	{
		InitializeComponent();
	}

    private void Return_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//NutritionView");
    }
}