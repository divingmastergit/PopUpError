using CommunityToolkit.Maui.Views;

namespace PopUPTest;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        var popup = new SimpleTestPopup();
        await Application.Current.MainPage.ShowPopupAsync(popup);
    }
}

public class SimpleTestPopup : Popup
{
    public SimpleTestPopup()
    {
            
        var label = new Label
        {
            Text = "Test-Popup",
            TextColor = Colors.Yellow,
            IsVisible = true
        };
            
        var frame = new Frame
        {
            Content = label,
        };
        Content = frame;

    }
}