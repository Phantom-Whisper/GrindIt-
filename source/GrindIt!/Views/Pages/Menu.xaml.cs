namespace GrindIt_.Views.Pages;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private void Theme_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("//ThemeView");
    }

    private void Exit_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//AccountView");
    }
}