using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries.ViewModel
{
    public class WeatherViewModel
    {
        public WeatherViewModel()
        {

        }
        public WeatherViewModel(Model.WeatherObject.WeatherRoot root)
        {
            Temperature = root.main.temp - 273.15;
            MaxTemperature = root.main.temp_max - 273.15;
            MinTemperature = root.main.temp_min - 273.15;
            WindSpeed = root.wind.speed;
            Pressure = root.main.pressure;
            CityName = root.name;
            WeatherDescription = root.weather[0].description;
            Longitude = root.coord.lon;
            Latitude = root.coord.lat;
        }

        public double Temperature { get; set; }
        public double MaxTemperature { get; set; }
        public double MinTemperature { get; set; }
        public double WindSpeed { get; set; }
        public double Pressure { get; set; }
        public string CityName { get; set; }
        public string WeatherDescription { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}

