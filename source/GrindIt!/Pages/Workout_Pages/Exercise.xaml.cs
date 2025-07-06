namespace GrindIt_.Pages.Workout_Pages;

public partial class Exercise
{
    public Exercise()
    {
        InitializeComponent();
    }

    private void Return_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}