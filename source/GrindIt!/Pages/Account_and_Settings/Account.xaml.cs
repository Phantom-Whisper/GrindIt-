namespace GrindIt_.Pages.Account_and_Settings;

public partial class Account : ContentPage
{
    public Account()
    {
        InitializeComponent();
    }

    private void Menu_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Menu");
    }
}