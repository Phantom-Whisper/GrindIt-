using System.Globalization;

namespace GrindIt_
{
    public partial class App
    {
        public App()
        {
            InitializeComponent();

            var savedTheme = Preferences.Default.Get<string>("Theme", "Light");

            Current!.UserAppTheme = savedTheme == "Dark"
                ? AppTheme.Dark
                : AppTheme.Light;
            
            var savedCulture = Preferences.Default.Get<string>("Culture", "en");
            
            var culture = new CultureInfo(savedCulture);
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            
            MainPage = new AppShell();
        }
    }
}
