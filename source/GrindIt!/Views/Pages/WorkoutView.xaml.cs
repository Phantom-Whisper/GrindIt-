namespace GrindIt_.Views.Pages;

public partial class WorkoutView : ContentPage
{
    public WorkoutView()
    {
        InitializeComponent();
    }

    private void Exercises_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Exercises");
    }
}