namespace GrindIt_.Components;

public partial class StepsCard : ContentView
{
	public StepsCard()
	{
		InitializeComponent();
		BindingContext = this;
	}

	public static readonly BindableProperty ValueProperty =
		BindableProperty.Create(nameof(Value), typeof(string), typeof(StepsCard), default(string));

	public static readonly BindableProperty TargetValueProperty =
		BindableProperty.Create(nameof(TargetValue), typeof(string), typeof(StepsCard), default(string));

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