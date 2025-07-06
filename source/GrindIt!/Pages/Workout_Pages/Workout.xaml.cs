namespace GrindIt_.Pages.Workout_Pages;

public partial class Workout
{
    public Workout()
    {
        InitializeComponent();
    }

    private void Exercises_Tapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Exercises());
    }
}