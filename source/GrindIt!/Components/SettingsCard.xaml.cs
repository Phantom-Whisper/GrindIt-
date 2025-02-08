using static System.Net.Mime.MediaTypeNames;

namespace GrindIt_.Components;

public partial class SettingsCard : ContentView
{
	public SettingsCard()
	{
		InitializeComponent();
        BindingContext = this;
    }

    public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(Card), default(string));

    public static readonly BindableProperty GlyphProperty =
            BindableProperty.Create(nameof(Glyph), typeof(string), typeof(Card), default(string));

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