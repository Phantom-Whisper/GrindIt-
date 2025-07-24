namespace GrindIt_.Pages.Account_and_Settings;

public partial class Account
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