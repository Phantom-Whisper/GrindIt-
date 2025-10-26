namespace GrindIt_.Pages.Nutrition_Pages;

public partial class Water
{
    public Water()
    {
        InitializeComponent();
    }

    private void Return_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}