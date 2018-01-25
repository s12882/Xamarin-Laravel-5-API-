using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PAMO
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CitiesListPage : ContentPage
    {
        public ObservableCollection<City> citiesList { get; set; }
        private WeatherPage _parent;

        public CitiesListPage(WeatherPage parent)
        {
            try { 
            InitializeComponent();
                _parent = parent;
               
                var Cities = App.Database.GetCities();
                citiesList = new ObservableCollection<City>();
                this.BindingContext = Cities;

                foreach (var city in Cities)
                    citiesList.Add(city);

                MyListView.ItemsSource = citiesList;
            }
            catch(Exception npe)
            {
                System.Diagnostics.Debug.WriteLine(npe);
            }
        }

       private async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
       {
            if (e.Item == null)
                return;

            var weatherPage = new WeatherPage();
            weatherPage.BindingContext = e.Item;
            await Navigation.PushAsync(weatherPage);

            ((ListView)sender).SelectedItem = null;
        }

        private void AddCity_OnClickedAsync(object sender, EventArgs e)
        {
            NewCityPage newCity = new NewCityPage(this);
            this.Navigation.PushAsync(newCity);
        }

        public void Refresh()
        {
            var Cities = App.Database.GetCities();
            citiesList = new ObservableCollection<City>();

            foreach (var city in Cities)
                citiesList.Add(city);

            MyListView.ItemsSource = citiesList;
        }


    }

}
