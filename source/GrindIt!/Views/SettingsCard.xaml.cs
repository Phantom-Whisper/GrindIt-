namespace GrindIt_.Views;

public partial class SettingsCard
{
	public SettingsCard()
	{
		InitializeComponent();
        BindingContext = this;
    }

    public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(SettingsCard));

    public static readonly BindableProperty GlyphProperty =
            BindableProperty.Create(nameof(Glyph), typeof(string), typeof(SettingsCard));

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public string Glyph
    {
        get => (string)GetValue(GlyphProperty);
        set => SetValue(GlyphProperty, value);
    }
}