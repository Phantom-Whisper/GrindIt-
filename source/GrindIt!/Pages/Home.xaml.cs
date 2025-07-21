namespace GrindIt_.Pages;

public partial class Home
{
    private int _count;

    public Home()
    {
        InitializeComponent();
    }
    
    private void OnCounterClicked(object sender, EventArgs e)
    {
        _count++;

        CounterBtn.Text = _count == 1 ? $"Clicked {_count} time" : $"Clicked {_count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}

