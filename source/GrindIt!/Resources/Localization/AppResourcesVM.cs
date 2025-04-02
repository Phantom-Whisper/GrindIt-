using System.ComponentModel;
namespace GrindIt_.Resources.Localization;


public class AppResourcesVM : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    void OnPropertyChanged(string propertyName)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    public System.Globalization.CultureInfo Culture
    {
        get => AppResources.Culture;
        set
        {
            if (AppResources.Culture == value) return;

            AppResources.Culture = value;
            OnPropertyChanged(nameof(Culture));
        }
    }
}