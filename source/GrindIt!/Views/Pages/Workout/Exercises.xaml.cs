namespace GrindIt_.Views.Pages;

public partial class Exercises : ContentPage
{
    public Exercises()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//CreateExercise");
    }

    private void Return_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//WorkoutView");
    }

    private void Exercise_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Exercise");
    }
}