namespace GrindIt_.Views.Pages;

public partial class LoginView : ContentPage
{
    public LoginView()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//RegistrationView");
    }

    private void Login_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Home");
    }
}