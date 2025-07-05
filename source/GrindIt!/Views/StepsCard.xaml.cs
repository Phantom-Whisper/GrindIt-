namespace GrindIt_.Views;

public partial class StepsCard
{
	public StepsCard()
	{
		InitializeComponent();
		BindingContext = this;
	}

	public static readonly BindableProperty ValueProperty =
		BindableProperty.Create(nameof(Value), typeof(string), typeof(StepsCard));

	public static readonly BindableProperty TargetValueProperty =
		BindableProperty.Create(nameof(TargetValue), typeof(string), typeof(StepsCard));

	public string Value
	{
		get => (string)GetValue(ValueProperty);
		set => SetValue(ValueProperty, value);
	}

	public string TargetValue
	{
		get => (string)GetValue(TargetValueProperty);
		set => SetValue(TargetValueProperty, value);
	}
}