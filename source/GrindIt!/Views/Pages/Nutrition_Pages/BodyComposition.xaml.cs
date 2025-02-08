namespace GrindIt_.Views.Pages;

public partial class BodyComposition : ContentPage
{
	public BodyComposition()
	{
		InitializeComponent();
	}

    private void Return_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//NutritionView");
    }
}