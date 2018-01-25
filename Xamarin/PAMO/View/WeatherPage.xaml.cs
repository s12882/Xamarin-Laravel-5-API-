using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PAMO
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherPage : ContentPage
    {
        City city;
        public WeatherPage()
        {
            InitializeComponent();
            BindingContext = new Weather();
        }

        private async void GetWeatherBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                City city = (City)BindingContext;
                Weather weather = await App.WeatherManager.GetWeather(city);
                BindingContext = weather;
            }
            catch (Exception ibe)
            {
                Debug.WriteLine(ibe);
                MainLabel.Text = "Choose city firts";
            }
        }
            

        private async void SetCityBtn_Clicked(object sender, EventArgs e)
        {          
            CitiesListPage citiesList = new CitiesListPage(this);
            await this.Navigation.PushAsync(citiesList);
        }

        

        public void getCurrentCity(City city)
        {
            BindingContext = city;
        }
        
    }
}