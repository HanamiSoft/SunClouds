using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SunClouds.View;
using SunClouds.ViewModel.Helpers;
namespace SunClouds.ViewModel
{
    internal class WeatherViewModel : BindingHelper
    {
        #region Свойства
        private object mainPageContent = new WeatherPage();

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

        #endregion
        #region Команды
        public BindableCommand ToSettingsСommand { get; set; } // Переход на страницу настроек
        public BindableCommand ToWeatherCommand { get; set; } // Переход на страницу погоды
        #endregion
        public WeatherViewModel()
        {
            ToSettingsСommand = new BindableCommand(_ => MainPageContent = new SettingsPage());
            ToWeatherCommand = new BindableCommand(_ => MainPageContent = new WeatherPage());
        }
    }
}