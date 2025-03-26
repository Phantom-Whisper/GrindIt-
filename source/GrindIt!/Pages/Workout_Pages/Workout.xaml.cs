namespace GrindIt_.Pages.Workout_Pages;

public partial class Workout : ContentPage
{
    public Workout()
    {
        InitializeComponent();
    }

    private void Exercises_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Exercises");
    }

    private void OnBorderTapped(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync("//Exercises");
    }
}