namespace GrindIt_.Pages.Nutrition_Pages;

public partial class Water : ContentPage
{
    public Water()
    {
        InitializeComponent();
    }

    private void Return_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//NutritionView");
    }
}