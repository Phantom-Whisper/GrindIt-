namespace GrindIt_.Pages.Workout_Pages;

public partial class CreateExercise : ContentPage
{
    public CreateExercise()
    {
        InitializeComponent();
    }
    
    private void Return_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Exercises");
    }
}