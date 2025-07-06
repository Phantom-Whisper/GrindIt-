namespace GrindIt_.Pages.Account_and_Settings;

public partial class Theme
{
    public Theme()
    {
        InitializeComponent();
        InitializeThemeSwitch();
    }

    private void InitializeThemeSwitch()
    {
        var savedTheme = Preferences.Default.Get("Theme", "Light");
        
        ThemeSwitch.IsToggled = savedTheme == "Dark";
        
        Application.Current!.UserAppTheme = savedTheme == "Dark" ? AppTheme.Dark : AppTheme.Light;
    }

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
        var chosenTheme = e.Value ? "Dark" : "Light";
        
        Preferences.Set("Theme", chosenTheme);
        
        Application.Current!.UserAppTheme = e.Value ? AppTheme.Dark : AppTheme.Light;
    }

    private void Return_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Menu");
    }
}