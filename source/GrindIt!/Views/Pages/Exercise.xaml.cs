namespace GrindIt_.Views.Pages;

public partial class Exercise : ContentPage
{
    public Exercise()
    {
        InitializeComponent();
    }

    private void Return_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Exercises");
    }
}