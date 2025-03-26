namespace GrindIt_.Pages.Nutrition_Pages;

public partial class Meal : ContentPage
{
	public Meal()
	{
		InitializeComponent();
	}

    private void Return_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//NutritionView");
    }
}