using System.Globalization;
namespace GrindIt_.Pages.Account_and_Settings;

public partial class PreferencesPage
{
	public PreferencesPage()
	{
		InitializeComponent();
        InitializeCulturePicker();
        BindingContext = this;
	}

    private void InitializeCulturePicker()
    {
        var savedCulture = Preferences.Default.Get("Culture", "System");

        CulturePicker.SelectedItem = savedCulture;
    }
    
    private void CulturePicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        var selectedCulture = CulturePicker.SelectedItem?.ToString() ?? "en-EN";
        Preferences.Default.Set("Culture", selectedCulture);

        // Update thread culture
        var culture = new CultureInfo(selectedCulture);
        CultureInfo.DefaultThreadCurrentCulture = culture;
        CultureInfo.DefaultThreadCurrentUICulture = culture;
    }

    private void Return_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Menu");
    }
}