using System.Globalization;
using GrindIt_.Models;
using GrindIt_.Resources.Localization;

namespace GrindIt_.Pages.Account_and_Settings;

public partial class PreferencesPage
{
    // Lists of all the culture I want to display
    private readonly List<CultureItem> _cultures = 
    [
         new() { Name = "English", Code = "en" },
         new() { Name = "Français", Code = "fr-FR"}
    ];
        
	public PreferencesPage()
	{
		InitializeComponent();
        InitializeCulturePicker();
        BindingContext = this;
	}

    /// <summary>
    /// Initialises the Culture Picker with the app current culture
    /// </summary>
    private void InitializeCulturePicker()
    {
        CulturePicker.ItemsSource = _cultures;
        
        var savedCulture = Preferences.Default.Get("Culture", "en");

        var selectedCulture = _cultures.FirstOrDefault(c => c.Code == savedCulture);
        CulturePicker.SelectedItem = selectedCulture;
    }
    
    /// <summary>
    /// Changes the culture
    /// </summary>
    private void CulturePicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (CulturePicker.SelectedItem is not CultureItem selectedCulture) return;

        Preferences.Default.Set("Culture", selectedCulture.Code);

        var culture = new CultureInfo(selectedCulture.Code);
        CultureInfo.DefaultThreadCurrentCulture = culture;
        CultureInfo.DefaultThreadCurrentUICulture = culture;

        LocalizationResourceManager.Instance.SetCulture(culture);
    }


    /// <summary>
    /// Navigates back to the previous page
    /// </summary>
    private void Return_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}