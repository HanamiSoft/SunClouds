using Newtonsoft.Json;
using SunClouds.Properties;
using SunClouds.View;
using SunClouds.ViewModel.Helpers;
using System;

namespace SunClouds.ViewModel
{
    internal class WeatherViewModel : BindingHelper
    {
        private static CurrentWeather current;
        private static ThreeHoursWeather weathercast;

        #region Свойства
        private object mainPageContent = new WeatherPage(current, weathercast);
        public object MainPageContent
        {
            get { return mainPageContent; }
            set
            {
                if (mainPageContent != value)
                {
                    mainPageContent = value;
                    OnPropertyChanged();
                }
            }
        }
        private string city = Settings.Default.City;
        public string City
        {
            get { return city; }
            set
            {
                    city = value;
                    OnPropertyChanged();
            }
        }
        public string Time1 { get; set; } = "";
        public string Time2 { get; set; } = "";
        public string Time3 { get; set; } = "";
        private string currentTip;

        public string CurrentTip
        {
            get { return currentTip; }
            set { currentTip = value; OnPropertyChanged(); }
        }

        private string tip1;

        public string Tip1
        {
            get { return tip1; }
            set { tip1 = value; }
        }

        private string tip2;

        public string Tip2
        {
            get { return tip2; }
            set { tip2 = value; }
        }
        private string tip3;

        public string Tip3
        {
            get { return tip3; }
            set { tip3 = value; }
        }


        private string img1;

        public string Img1
        {
            get { return img1; }
            set { img1 = value; OnPropertyChanged(); }
        }
        private string img2;

        public string Img2
        {
            get { return img2; }
            set { img2 = value; }
        }
        private string img3;

        public string Img3
        {
            get { return img3; }
            set { img3 = value; }
        }
        private string img4;

        public string Img4
        {
            get { return img4; }
            set { img4 = value; }
        }


        #endregion
        #region Команды
        public BindableCommand ToSettingsСommand { get; set; } // Переход на страницу настроек
        public BindableCommand ToWeatherCommand { get; set; } // Переход на страницу погоды
        #endregion
        public WeatherViewModel()
        {
            try
            {
                current = JsonConvert.DeserializeObject<CurrentWeather>(APIHelper.GetNow());
                weathercast = JsonConvert.DeserializeObject<ThreeHoursWeather>(APIHelper.GetThreeHours());
            }
            catch (Exception)
            {
            
            }
            ToSettingsСommand = new BindableCommand(_ => MainPageContent = new SettingsPage());
            ToWeatherCommand = new BindableCommand(_ => MainPageContent = new WeatherPage(current, weathercast));
            LoadData();
            mainPageContent = new WeatherPage(current, weathercast);
        }

        
        private void LoadData()
        {
            if (weathercast == null || current == null) return;
            Time1 = weathercast.list[0].dt_txt.ToString().Substring(11, 5);
            Time2 = weathercast.list[1].dt_txt.ToString().Substring(11, 5);
            Time3 = weathercast.list[2].dt_txt.ToString().Substring(11, 5);
            // Добавление картинок погоды и русского названия погоды
            LoadHoursData(0, ref currentTip, ref img1);
            LoadHoursData(1, ref tip1, ref img2);
            LoadHoursData(2, ref tip2, ref img3);
            LoadHoursData(3, ref tip3, ref img4);
            
        }

        /// <summary>
        /// Принимает на вход индекс массива погоды, свойства описания погоды и пути до картинки. <br/> Меняет их в зависимости от погоды
        /// </summary>
        /// <param name="i"></param>
        /// <param name="tip"></param>
        /// <param name="imgPath"></param>
        private void LoadHoursData(UInt16 i, ref string tip, ref string imgPath)
        {
            switch (weathercast.list[i].weather[0].main)
            {
                case "Clear":
                    tip = "Ясно. " + current.main.temp.ToString().Split(',')[0] + "° " + "Ощущается как " + current.main.feels_like.ToString().Split(',')[0] + "°";
                    imgPath = "/Pictures/Sunny.png";
                    break;
                case "Clouds":
                    tip = "Облачно. " + current.main.temp.ToString().Split(',')[0] + "° " + "Ощущается как " + current.main.feels_like.ToString().Split(',')[0] + "°";
                    imgPath = "/Pictures/Cloudy.png";
                    break;
                case "Snow":
                    tip = "Снег. " + current.main.temp.ToString().Split(',')[0] + "° " + "Ощущается как " + current.main.feels_like.ToString().Split(',')[0] + "°";
                    imgPath = "/Pictures/Snow.png";
                    break;
                case "Rain":
                    tip = "Дождь. " + current.main.temp.ToString().Split(',')[0] + "° " + "Ощущается как " + current.main.feels_like.ToString().Split(',')[0] + "°";
                    imgPath = "/Pictures/Rainy.png";
                    break;
                case "Blizzard":
                    tip = "Метель. " + current.main.temp.ToString().Split(',')[0] + "° " + "Ощущается как " + current.main.feels_like.ToString().Split(',')[0] + "°";
                    imgPath = "/Pictures/Blizzard.png";
                    break;
                case "Wind":
                    tip = "Ветер. " + current.main.temp.ToString().Split(',')[0] + "° " + "Ощущается как " + current.main.feels_like.ToString().Split(',')[0] + "°";
                    imgPath = "/Pictures/Wind.png";
                    break;
                case "Thunderstorm":
                    tip = "Ветер. " + current.main.temp.ToString().Split(',')[0] + "° " + "Ощущается как " + current.main.feels_like.ToString().Split(',')[0] + "°";
                    imgPath = "/Pictures/Thunderstorm.png";
                    break;
                default:
                    break;
            }
        }
    }
}