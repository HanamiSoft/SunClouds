using SunClouds.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunClouds.ViewModel
{
    internal class WeatherHourViewModel : BindingHelper
    {
        #region props
        private string date;

        public string Date
        {
            get { return date; }
            set { date = value; OnPropertyChanged(); }
        }
        private string humidity;

        public string Humidity
        {
            get { return humidity; }
            set { humidity = value; OnPropertyChanged(); }
        }
        private string feels;

        public string Feels
        {
            get { return feels; }
            set { feels = value; OnPropertyChanged(); }
        }
        private string imgPath;

        public string Img
        {
            get { return imgPath; }
            set { imgPath = value; }
        }




        #endregion
        public WeatherHourViewModel(string date, string humidity, string feels, string imgPath) 
        {
            this.date= date + "°";
            this.humidity= "Влаж. " + humidity + "°"; 
            this.feels= "Ощущ." + feels + "°";
            this.imgPath = imgPath;
        }

    }
}
