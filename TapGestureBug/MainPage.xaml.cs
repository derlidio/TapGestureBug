using System.Windows.Input;

namespace TapGestureBug;

public partial class MainPage : ContentPage
{
	int count = 0;

    public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        Tapped();
	}

    void Tapped(object sender, TappedEventArgs e)
    {
        Tapped();
    }

    private void Tapped()
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}