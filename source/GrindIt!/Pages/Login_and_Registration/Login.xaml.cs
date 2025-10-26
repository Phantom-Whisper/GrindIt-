namespace GrindIt_.Pages.Login_and_Registration;

public partial class Login
{
    public Login()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Registration");
    }

    private void Login_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Home");
    }
}