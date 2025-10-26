namespace GrindIt_.Views;

public partial class Card
{
    public Card()
    {
        InitializeComponent();
        BindingContext = this; 
    }

    public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(Card));

    public static readonly BindableProperty ValueProperty =
            BindableProperty.Create(nameof(Value), typeof(string), typeof(Card));

    public static readonly BindableProperty GlyphProperty =
            BindableProperty.Create(nameof(Glyph), typeof(string), typeof(Card));


    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public string Value
    {
        get => (string)GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
    }

    public string Glyph
    {
        get => (string)GetValue(GlyphProperty);
        set => SetValue(GlyphProperty, value);
    }

}