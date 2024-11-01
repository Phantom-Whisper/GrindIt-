namespace GrindIt_.Components;

public partial class Card : ContentView
{
    public Card()
    {
        InitializeComponent();
        BindingContext = this; 
    }

    public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(Card), default(string));

    public static readonly BindableProperty ValueProperty =
            BindableProperty.Create(nameof(Value), typeof(string), typeof(Card), default(string));

    public static readonly BindableProperty ImageSourceProperty =
            BindableProperty.Create(nameof(ImageSource), typeof(string), typeof(Card), default(string));


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

    public string ImageSource
    {
        get => (string)GetValue(ImageSourceProperty);
        set => SetValue(ImageSourceProperty, value);
    }

}