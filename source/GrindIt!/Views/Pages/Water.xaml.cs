namespace GrindIt_.Views.Pages;

public partial class Water : ContentPage
{
    public Water()
    {
        InitializeComponent();
    }

    private void Back_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//NutritionView");
    }
}