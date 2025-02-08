namespace GrindIt_.Views.Pages;

public partial class RegistrationView : ContentPage
{
    public RegistrationView()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Home");
    }
}