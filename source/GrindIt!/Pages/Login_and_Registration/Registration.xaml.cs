namespace GrindIt_.Pages.Login_and_Registration;

public partial class Registration
{
    public Registration()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Home");
    }
}