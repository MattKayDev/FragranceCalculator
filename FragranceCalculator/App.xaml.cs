using FragranceCalculator.Views;

namespace FragranceCalculator;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CalculatorPageView();
	}
}
