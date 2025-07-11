using System.ComponentModel;
using System.Globalization;

namespace GrindIt_.Resources.Localization;

public class LocalizationResourceManager : INotifyPropertyChanged
{
    public static LocalizationResourceManager Instance { get; } = new();

    public event PropertyChangedEventHandler? PropertyChanged;

    public string this[string text]
    {
        get
        {
            var translation = AppResources.ResourceManager.GetString(text, AppResources.Culture);
            return translation ?? $"[{text}]";
        }
    }

    public void SetCulture(CultureInfo culture)
    {
        if (Equals(AppResources.Culture, culture))
            return;

        AppResources.Culture = culture;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null)); // updates all bindings
    }
}