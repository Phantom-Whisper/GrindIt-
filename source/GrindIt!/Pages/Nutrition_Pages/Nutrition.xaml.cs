namespace GrindIt_.Pages.Nutrition_Pages;

public partial class Nutrition
{
    public Nutrition()
    {
        InitializeComponent();
    }

    private void OnMealTapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Meal());
    }

    private void OnStepsTapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Steps());
    }

    private void OnWaterTapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new Water());
    }

    private void OnSleepTapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new Sleep());
    }

    private void OnBodyTapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new BodyComposition());
    }
}