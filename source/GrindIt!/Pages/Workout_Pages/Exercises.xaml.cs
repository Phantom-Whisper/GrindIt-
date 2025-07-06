namespace GrindIt_.Pages.Workout_Pages;

public partial class Exercises
{
    public Exercises()
    {
        InitializeComponent();
    }

    private void CreateExercise_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CreateExercise());
    }
    private void Exercise_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Exercise());
    }

    private void Return_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}