using Countries.DB;
using Countries.Model;
using Countries.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin;
using Xamarin.Forms;

namespace Countries.View
{
    public partial class CityListPage : ContentPage
    {
        private readonly CountryDatabase _db;
        public CountriesViewModel _countries;
        public CityListPage()
        {
            _db = new CountryDatabase();
            _countries = new CountriesViewModel();
            _countries.Countries = _db.GetAll().Select(c => new CountryDetailsViewModel(c)).ToList(); //foreach loopar på alla värden i 
                                                                                                      //databasen och omvandla dem till vår ViewModel
            InitializeComponent();
            BindingContext = _countries;
        }

        private async void OnItemTapped(object o, ItemTappedEventArgs e)
        {
            var selectedObject = e.Item as CountryDetailsViewModel;

            var response = await GetCurrentWeather(selectedObject.CapitalName);
            try
            {
                var weather = JsonConvert.DeserializeObject<WeatherObject.WeatherRoot>(response);
                selectedObject.Weather = new WeatherViewModel(weather);
                if (selectedObject.Weather.Temperature.ToString().Contains("."))
                {
                    try
                    {
                        selectedObject.Weather.Temperature =
                        double.Parse(selectedObject.Weather.Temperature.ToString()
                        .Substring(0, selectedObject.Weather.Temperature.ToString()
                        .IndexOf('.') + 3));
                    }
                    catch
                    {
                        selectedObject.Weather.Temperature =
                        double.Parse(selectedObject.Weather.Temperature.ToString()
                        .Substring(0, selectedObject.Weather.Temperature.ToString()
                        .IndexOf('.') + 2));
                    }

                }

                if (selectedObject.Weather.MinTemperature.ToString().Contains("."))
                {
                    try
                    {
                        selectedObject.Weather.MinTemperature =
                                       double.Parse(selectedObject.Weather.MinTemperature.ToString()
                                       .Substring(0, selectedObject.Weather.MinTemperature.ToString()
                                       .IndexOf('.') + 3));
                    }
                    catch 
                    {
                        selectedObject.Weather.MinTemperature =
                                       double.Parse(selectedObject.Weather.MinTemperature.ToString()
                                       .Substring(0, selectedObject.Weather.MinTemperature.ToString()
                                       .IndexOf('.') + 2));
                    }

                }

                if (selectedObject.Weather.MaxTemperature.ToString().Contains("."))
                {
                    try
                    {
                        selectedObject.Weather.MaxTemperature =
                        double.Parse(selectedObject.Weather.MaxTemperature.ToString()
                        .Substring(0, selectedObject.Weather.MaxTemperature.ToString()
                        .IndexOf('.') + 3));
                    }
                    catch 
                    {
                        selectedObject.Weather.MaxTemperature =
                        double.Parse(selectedObject.Weather.MaxTemperature.ToString()
                        .Substring(0, selectedObject.Weather.MaxTemperature.ToString()
                        .IndexOf('.') + 2));
                    }
                    
                }
                //Insights.Track("CitiesListSelectedItem", "Selected City", selectedObject.CapitalName);
                await Navigation.PushAsync(new CountryDetailsPage(selectedObject));
            }
            catch (Exception ex)
            {
                Insights.Report(ex, Insights.Severity.Error);
                await DisplayAlert("Ops!", "Something went wrong, we will back as soon as possible.", "OK");
            }
        }

        private async Task<string> GetCurrentWeather(string city)
        {
            using (Insights.TrackTime("Selected City Information", "City Name", city))
            {
                string url = String.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid=fd3d63c60c1106a02499aeef93a2353f", city);
                HttpClient client = new HttpClient();
                var response = await client.GetStringAsync(url);
                return response;
            }

        }

        private void OnTextChanged(object o, TextChangedEventArgs e)
        {
            _countries.Countries = _db.GetAll().Where(c => c.capital.ToLower().Contains(cityName.Text.ToLower()) ||
            c.countryName.ToLower().Contains(cityName.Text.ToLower()))
                .Select(c => new CountryDetailsViewModel(c)).ToList();
        }
    }
}
