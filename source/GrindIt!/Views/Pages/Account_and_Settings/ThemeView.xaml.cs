namespace GrindIt_.Views.Pages;

public partial class ThemeView : ContentPage
{
    public ThemeView()
    {
        InitializeComponent();
    }

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
        if (e.Value)
        {
            App.Current.UserAppTheme = AppTheme.Dark;
        }
        else
        {
            App.Current.UserAppTheme = AppTheme.Light;
        }
    }

    private void Return_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Menu");
    }
}