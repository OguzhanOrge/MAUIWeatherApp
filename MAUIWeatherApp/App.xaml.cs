using MAUIWeatherApp.MVVM.Views;

namespace MAUIWeatherApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new WeatherView();
        }
    }
}
