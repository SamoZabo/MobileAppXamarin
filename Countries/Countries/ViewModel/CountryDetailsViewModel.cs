using Countries.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries.ViewModel
{
    public class CountryDetailsViewModel
    {
        public CountryDetailsViewModel()
        {

        }
        public CountryDetailsViewModel(Country country)
        {
            CountryName = country.countryName;
            CountryCode = country.countryCode;
            CapitalName = country.capital;
            CurrencyCode = country.currencyCode;
            Continent = country.continentName;
            Population = country.population;
            Area = country.areaInSqKm;
        }

        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string CapitalName { get; set; }
        public string CurrencyCode { get; set; }
        public string Continent { get; set; }
        public string Population { get; set; }
        public string Area { get; set; }
        public DateTime CurrentTime { get { return DateTime.Now.ToLocalTime(); } }
        public WeatherViewModel Weather { get; set; }

    }
}
