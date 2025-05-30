using GrindIt_.Resources.Localization;
using Microsoft.Maui.Storage;
namespace GrindIt_.Pages.Account_and_Settings;

public partial class Preferences : ContentPage
{
	public Preferences()
	{
		InitializeComponent();
        //InitializeCulturePicker();
	}

    //private void InitializeCulturePicker()
    //{
    //    string savedCulture = Preferences.Get("Culture", "en-EN");
    //    CulturePicker.SelectedItem = savedCulture;
    //}

    private void Return_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Menu");
    }
}