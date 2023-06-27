using Newtonsoft.Json;
using SunClouds.View;
using SunClouds.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunClouds.ViewModel
{
    internal class WeatherPageViewModel : BindingHelper
    {
        #region props
        private object graphPage = new GraphicTemperaturePage();

        public object GraphPage
        {
            get { return graphPage; }
            set { graphPage = value; }
        }

        public string CurrentTemperature { get; set; }
        private ObservableCollection<FeelingUC> toolbarContent = new ObservableCollection<FeelingUC>();
        public ObservableCollection<FeelingUC> ToolbarContent
        {
            get { return toolbarContent; }
            set
            {
                toolbarContent = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<UserWeatherHour> hoursList = new ObservableCollection<UserWeatherHour>();

        public ObservableCollection<UserWeatherHour> HoursList
        {
            get { return hoursList; }
            set { hoursList = value; OnPropertyChanged(); }
        }

        #endregion
        #region commands
        public BindableCommand ToGTemp { get; set; }
        public BindableCommand ToGFeels { get; set; }
        public BindableCommand ToGPressure { get; set; }
        #endregion
        public WeatherPageViewModel(CurrentWeather current, ThreeHoursWeather weathercast)
        {
            LoadData(current, weathercast);
            ToGTemp = new BindableCommand(_ => graphPage = new GraphicTemperaturePage());
            ToGFeels = new BindableCommand(_ => graphPage = new GraphicFeelingsPage());
            ToGPressure = new BindableCommand(_ => graphPage = new GraphicPressurePage());
        }
        private void LoadData(CurrentWeather current, ThreeHoursWeather weathercast)
        {
            CurrentTemperature = current.main.temp.ToString().Substring(0, 2) + "°";
            ToolbarContent.Add(new FeelingUC("Ощущение:", current.main.feels_like.ToString().Substring(0, 2) + "°"));
            ToolbarContent.Add(new FeelingUC("Мин.", current.main.temp_min.ToString().Substring(0, 2) + "°"));
            ToolbarContent.Add(new FeelingUC("Макс.", current.main.temp_max.ToString().Substring(0, 2) + "°"));
            ToolbarContent.Add(new FeelingUC("Давление:", current.main.pressure.ToString() + " мм рт. ст."));
            ToolbarContent.Add(new FeelingUC("Влажность:", current.main.humidity.ToString().Substring(0, 2) + "%"));
            ToolbarContent.Add(new FeelingUC("Ветер м\\с:", current.wind.speed.ToString().Split(',')[0] + " м\\с"));
            ToolbarContent.Add(new FeelingUC("Ветер °:", current.wind.deg.ToString()));
            for (int i = 0; i < 9; i++)
            {
                string imgPath = string.Empty;
                switch (weathercast.list[i].weather[0].main)
                {
                    case "Clear":
                        imgPath = "/Pictures/Sunny.png";
                        break;
                    case "Clouds":
                        imgPath = "/Pictures/Cloudy.png";
                        break;
                    case "Snow":
                        imgPath = "/Pictures/Snow.png";
                        break;
                    case "Rain":
                        imgPath = "/Pictures/Rainy.png";
                        break;
                    case "Blizzard":
                        imgPath = "/Pictures/Blizzard.png";
                        break;
                    case "Wind":
                        imgPath = "/Pictures/Wind.png";
                        break;
                    case "Thunderstorm":
                        imgPath = "/Pictures/Thunderstorm.png";
                        break;
                }
                hoursList.Add(new UserWeatherHour(weathercast.list[i].dt_txt.Substring(11, 5) + " " + weathercast.list[i].main.temp.ToString().Split(',')[0], weathercast.list[i].main.humidity.ToString(), weathercast.list[i].main.feels_like.ToString().Split(',')[0], imgPath));
            }
        }

    }
}
