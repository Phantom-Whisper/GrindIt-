namespace GrindIt_.Views.Pages;

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