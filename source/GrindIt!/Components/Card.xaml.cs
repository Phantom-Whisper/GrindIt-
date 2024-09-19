namespace GrindIt_.Components;

public partial class Card : ContentView
{
    public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(Card), default(string));

    // Propri�t� publique pour acc�der � la propri�t� Bindable
    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public Card()
    {
        InitializeComponent();
        BindingContext = this; // Fixe le contexte de donn�es � l'instance actuelle pour le Binding
    }
}