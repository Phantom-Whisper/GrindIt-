namespace GrindIt_.Pages.Workout_Pages;

public partial class Exercise
{
    private ScrollView? _statsContent;
    
    public Exercise()
    {
        InitializeComponent();
        CreateStatsContent();
    }

    private void CreateStatsContent()
    {
        _statsContent = new ScrollView
        {
            Content = new VerticalStackLayout
            {
                Padding = new Thickness(20),
                Children =
                {
                    new Label 
                    { 
                        Text = "Exercise Statistics", 
                        FontSize = 16, 
                        FontAttributes = FontAttributes.Bold,
                        Margin = new Thickness(0, 0, 0, 20)
                    },
                    new Grid
                    {
                        ColumnDefinitions = 
                        {
                            new ColumnDefinition { Width = GridLength.Star },
                            new ColumnDefinition { Width = GridLength.Star }
                        },
                        RowDefinitions =
                        {
                            new RowDefinition { Height = GridLength.Auto },
                            new RowDefinition { Height = GridLength.Auto },
                            new RowDefinition { Height = GridLength.Auto },
                            new RowDefinition { Height = GridLength.Auto },
                            new RowDefinition { Height = GridLength.Auto },
                            new RowDefinition { Height = GridLength.Auto }
                        },
                        RowSpacing = 15,
                        Children =
                        {
                            CreateStatLabel("Total Sessions:", 0, 0, true),
                            
                            CreateStatLabel("Max Weight:", 1, 0, true),
                            
                            CreateStatLabel("Max Reps:", 2, 0, true),
                            
                            CreateStatLabel("Total Volume:", 3, 0, true),
                            
                            CreateStatLabel("Average Weight:", 4, 0, true),
                            
                            CreateStatLabel("Average Reps:", 5, 0, true),
                        }
                    }
                }
            }
        };
    }

    private Label CreateStatLabel(string text, int row, int column, bool isBold)
    {
        var label = new Label
        {
            Text = text,
            FontAttributes = isBold ? FontAttributes.Bold : FontAttributes.None
        };
        
        Grid.SetRow(label, row);
        Grid.SetColumn(label, column);
        
        if (column == 1)
            label.HorizontalOptions = LayoutOptions.End;
            
        return label;
    }

    // Custom tab switcher
    private void HistoryTab_Clicked(object sender, EventArgs e)
    {
        // Update button styles
        HistoryTabButton.BackgroundColor = Application.Current!.RequestedTheme == AppTheme.Light 
            ? Color.FromArgb("#E0E0E0") : Color.FromArgb("#404040");
        HistoryTabButton.TextColor = Application.Current.RequestedTheme == AppTheme.Light 
            ? Colors.Black : Colors.White;
            
        StatsTabButton.BackgroundColor = Colors.Transparent;
        StatsTabButton.TextColor = Application.Current.RequestedTheme == AppTheme.Light 
            ? Color.FromArgb("#666666") : Color.FromArgb("#AAAAAA");

        // Switch content
        TabContentView.Content = HistoryContent;
    }

    private void StatsTab_Clicked(object sender, EventArgs e)
    {
        // Update button styles
        StatsTabButton.BackgroundColor = Application.Current!.RequestedTheme == AppTheme.Light 
            ? Color.FromArgb("#E0E0E0") : Color.FromArgb("#404040");
        StatsTabButton.TextColor = Application.Current.RequestedTheme == AppTheme.Light 
            ? Colors.Black : Colors.White;
            
        HistoryTabButton.BackgroundColor = Colors.Transparent;
        HistoryTabButton.TextColor = Application.Current.RequestedTheme == AppTheme.Light 
            ? Color.FromArgb("#666666") : Color.FromArgb("#AAAAAA");

        // Switch content
        TabContentView.Content = _statsContent;
    }

    private void Return_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}