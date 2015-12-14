using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Countries.ViewModel
{
    public class CountriesViewModel : INotifyPropertyChanged
    {
        public CountriesViewModel()
        {
            Countries = new List<CountryDetailsViewModel>();
        }

        private IList<CountryDetailsViewModel> myCountries;
        public IList<CountryDetailsViewModel> Countries
        {
            get { return myCountries; }
            set
            {
                myCountries = value;
                OnPropertyChanged("Countries");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
