using System;
using System.Collections.Generic;
using System.Text;

namespace PAMO
{
    public class Weather
    {
        public string Title { get; set; } = " ";
        public string Temperature { get; set; } = " ";
        public string Wind { get; set; } = " ";
        public string Humidity { get; set; } = " ";
        public string Visibility { get; set; } = " ";
        public string Sunrise { get; set; } = " ";
        public string Sunset { get; set; } = " ";
        public City city { get; set; }
        public string city_name { get; set; }

        public Weather()
        {

        }

        public Weather(City city)
        {
            this.city = city;
        }

    }
}
