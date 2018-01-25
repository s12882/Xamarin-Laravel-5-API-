using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;
using static System.DateTime;

namespace PAMO
{
    public class WeatherManager
    {
        IRestService restService;

        public WeatherManager(IRestService service)
        {
            restService = service;
        }

        public async Task<Weather> GetWeather(City city)
        {
            
            //Sign up for a free API key at http://openweathermap.org/appid  
            string key = "9e790e6ce426772ed7f9867435af1c89";
            string queryString = "http://api.openweathermap.org/data/2.5/weather?zip="
                + city.ZipCode + ",pl&appid=" + key + "&units=imperial";
            

                dynamic results = await restService.getWeather(queryString).ConfigureAwait(false);
                    
                Weather weather = new Weather();
                weather.Title = (string)results["name"];
                weather.Temperature = (string)results["main"]["temp"] + " F";
                weather.Wind = (string)results["wind"]["speed"] + " mph";
                weather.Humidity = (string)results["main"]["humidity"] + " %";
                weather.Visibility = (string)results["weather"][0]["main"];

                DateTime time = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                DateTime sunrise = time.AddSeconds((int)results["sys"]["sunrise"]);
                DateTime sunset = time.AddSeconds((int)results["sys"]["sunset"]);
                weather.Sunrise = sunrise.ToString() + " UTC";
                weather.Sunset = sunset.ToString() + " UTC";
                weather.city = city;
                weather.city_name = city.city_name;

            return weather;      
        }
    }
}
