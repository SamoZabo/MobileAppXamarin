using Countries.DB;
using Countries.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Countries.View
{
    public partial class StartPage : ContentPage
    {
        CountryDatabase _db;
        public StartPage()
        {
            _db = new CountryDatabase();
            InitializeComponent();
        }

        private async Task<string> CountriesAsync()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://api.geonames.org/countryInfo?username=samoalzobaydee&type=JSON");
            return response;
        }

        private async void GetCountries(object sender, EventArgs e)
        {
            var response = await CountriesAsync();
            var countries = JsonConvert.DeserializeObject<GeoCountries>(response);
            foreach (var country in countries.geonames)
            {
                _db.Save(country);
            }
            var c = _db.GetAll();
        }
    }
}
