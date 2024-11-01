namespace GrindIt_.Views.Pages;

public partial class NutritionView : ContentPage
{
    public NutritionView()
    {
        InitializeComponent();
    }

    private void OnMealTapped(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Meal");
    }

    private void OnStepsTapped(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Steps");
    }

    private void OnBorderTapped(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync("//Water");
    }

    private void OnSleepTapped(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync("//Sleep");
    }

    private void OnBodyTapped(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync("//BodyComposition");
    }
}