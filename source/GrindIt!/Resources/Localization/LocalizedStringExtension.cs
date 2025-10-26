using System.Globalization;

namespace GrindIt_.Resources.Localization;

public class LocalizationApp
{
    public string Culture
    {
        get => _culture;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) return;
            _culture = value;
            LocalizationResourceManager.Instance.SetCulture(new CultureInfo(_culture));
        }
    }
    private string _culture = "en";
}

[AcceptEmptyServiceProvider]
public class LocalizedStringExtension : IMarkupExtension<BindingBase>
{
    public required string Key { get; set; }

    public BindingBase ProvideValue(IServiceProvider serviceProvider)
    {
        return new Binding($"[{Key}]", 
            source: LocalizationResourceManager.Instance,
            mode: BindingMode.OneWay);
    }

    object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        => ProvideValue(serviceProvider);
}
