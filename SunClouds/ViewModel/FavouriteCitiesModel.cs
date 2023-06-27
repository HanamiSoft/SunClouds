using SunClouds.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunClouds.ViewModel
{
    class FavouriteCitiesModel : BindingHelper
    {
        private string country;
        public string Country
        {
            get { return country; }
            set
            {
                country = value;
                OnPropertyChanged(nameof(Country));
            }
        }

        private string shirota;
        public string Shirota
        {
            get { return shirota; }
            set
            {
                shirota = value;
                OnPropertyChanged(nameof(Shirota));
            }
        }


    }
}
