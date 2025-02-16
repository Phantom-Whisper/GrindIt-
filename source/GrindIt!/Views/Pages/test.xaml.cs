namespace GrindIt_.Views.Pages;

public partial class test : ContentPage
{
	public test()
	{
		InitializeComponent();
	}

    private void Return_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//NutritionView");
    }
}