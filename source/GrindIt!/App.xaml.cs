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
            
            MainPage = new AppShell();
        }
    }
}
