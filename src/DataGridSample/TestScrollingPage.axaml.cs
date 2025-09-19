using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace DataGridSample;

public class ListItem
{
    public string Text { get; set; } = string.Empty;
}

public partial class TestScrollingPage : UserControl
{
    private readonly AvaloniaList<ListItem> _dgItems = [
            new() { Text = "First item" },
            new() { Text = "Second Item" }
        ];
    public TestScrollingPage()
    {
        InitializeComponent();

        dg1.ItemsSource = _dgItems;
    }

    void Add_Click(object sender, RoutedEventArgs e)
    {
        _dgItems.Add(new()
        {
            Text = "Item " + _dgItems.Count
        });
    }

    void Remove_Click(object sender, RoutedEventArgs e)
    {
        if (_dgItems.Count > 0)
            _dgItems.RemoveAt(_dgItems.Count - 1);
    }
}
