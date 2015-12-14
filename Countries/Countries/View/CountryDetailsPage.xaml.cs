using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Countries.ViewModel;
using Xamarin.Forms;
using Countries.Interface;

namespace Countries.View
{
    public partial class CountryDetailsPage : ContentPage
    {
        public CountryDetailsViewModel _country;
        public CountryDetailsPage(CountryDetailsViewModel model)
        {
            _country = model != null ? model : new CountryDetailsViewModel();
            InitializeComponent();
            BindingContext = _country;
        }

        private void GetCountryOnMap(object sender, EventArgs e)
        {
            DependencyService.Get<IOpenMap>().OpenMap(_country.Weather.Latitude, _country.Weather.Longitude);
        }

        private void TalkToMe(object sender, EventArgs e)
        {
            DependencyService.Get<ICanTextToSpeach>().Say(cityToSpeak.Text);
        }
    }
}
