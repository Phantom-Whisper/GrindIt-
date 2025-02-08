namespace GrindIt_.Views.Pages;

public partial class AccountView : ContentPage
{
    public AccountView()
    {
        InitializeComponent();
    }

    private void Menu_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Menu");
    }
}