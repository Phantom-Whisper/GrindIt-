namespace GrindIt_.Components;

public partial class Card : ContentView
{
    public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(Card), default(string));

    // Propriété publique pour accéder à la propriété Bindable
    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public Card()
    {
        InitializeComponent();
        BindingContext = this; // Fixe le contexte de données à l'instance actuelle pour le Binding
    }
}