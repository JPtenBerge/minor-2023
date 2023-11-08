namespace ThreadingLab;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void CalculateButton_Click(object sender, EventArgs e)
	{
        CalculateButton.IsEnabled = false;

        // ...

        CalculateButton.IsEnabled = true;

    }
}

