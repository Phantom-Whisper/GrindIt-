namespace GrindIt_.Views;

public partial class ExercisesCard
{
    public ExercisesCard()
    {
        InitializeComponent();
        BindingContext = this;
    }
    
    private static readonly BindableProperty NameProperty =
        BindableProperty.Create(nameof(Name), typeof(string), typeof(ExercisesCard));

    private static readonly BindableProperty InitialProperty =
        BindableProperty.Create(nameof(Initial), typeof(string), typeof(ExercisesCard));

    public string Name
    {
        get => (string)GetValue(NameProperty);
        set => SetValue(NameProperty, value);
    }

    public string Initial
    {
        get => (string)GetValue(InitialProperty);
        set => SetValue(InitialProperty, value);
    }
}