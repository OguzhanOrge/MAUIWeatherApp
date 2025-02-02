using MAUIWeatherApp.MVVM.ViewModels;

namespace MAUIWeatherApp.MVVM.Views;

public partial class WeatherView : ContentPage
{

	public WeatherView()
	{
		InitializeComponent();
		BindingContext = new WeatherViewModel();
    }
}