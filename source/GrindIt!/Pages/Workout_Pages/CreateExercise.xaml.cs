namespace GrindIt_.Pages.Workout_Pages;

public partial class CreateExercise
{
    public CreateExercise()
    {
        InitializeComponent();
    }
    
    private void Return_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}