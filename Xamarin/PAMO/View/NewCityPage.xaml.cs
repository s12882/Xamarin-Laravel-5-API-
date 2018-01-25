using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PAMO
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewCityPage : ContentPage
    {
        private CitiesListPage _parent;

        public NewCityPage(CitiesListPage parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private Boolean AddButton_OnClicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(nameEntry.Text) && !String.IsNullOrEmpty(zipCodeEntry.Text))
            {
                City newCity = new City(nameEntry.Text, zipCodeEntry.Text);
                 App.Database.AddCity(newCity);

                _parent.Refresh();
                return base.OnBackButtonPressed();
            }
            return false;
        }
    }
}