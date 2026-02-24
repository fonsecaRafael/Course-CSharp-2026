using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaApp.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void ClickHandler(object sender, RoutedEventArgs args)
    {
        message.Text = "Button clicked!";
    }
}