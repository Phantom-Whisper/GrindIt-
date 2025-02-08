namespace GrindIt_.Views.Pages;

public partial class Steps : ContentPage
{
	public Steps()
	{
		InitializeComponent();
	}

    private void Return_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//NutritionView");
    }
}