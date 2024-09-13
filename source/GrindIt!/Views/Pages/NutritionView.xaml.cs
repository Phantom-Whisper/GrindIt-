namespace GrindIt_.Views.Pages;

public partial class NutritionView : ContentPage
{
    public NutritionView()
    {
        InitializeComponent();
    }

    private void Water_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Water");
    }
}