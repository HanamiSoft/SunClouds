using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SunClouds.ViewModel.Helpers
{
    /// <summary>
    /// Класс-помощник для биндинга(привязки) ваших свойств из ViewModel во View, в MVVM.
    /// </summary>
    internal class BindingHelper : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public BindingHelper()
        {
            int hour = DateTime.Now.Hour;

            if (hour >= 0 && hour <= 3)
            {
                App.Theme = "NightTheme";
                App.Button = "NightTheme";
                App.ButtonInWeather = "NightTheme";
                App.TextBox = "NightTheme";
                App.Label = "NightTheme";
                App.WeatherLabelStyle20px = "NightTheme";
                App.WeatherLabelStyle26px = "NightTheme";
                App.RectangleCity = "NightTheme";
                App.CartOneStyle = "NightTheme";
                App.CartTwoStyle = "NightTheme";
                App.CartThreeStyle = "NightTheme";
                App.WatermarkStyle = "NightTheme";
            }
            else if (hour >= 4 && hour <= 11 || hour >= 17 && hour <= 23)
            {
                App.Theme = "MorningEveningTheme";
                App.Button = "MorningEveningTheme";
                App.TextBox = "MorningEveningTheme";
                App.ButtonInWeather = "MorningEveningTheme";
                App.Label = "MorningEveningTheme";
                App.WeatherLabelStyle20px = "MorningEveningTheme";
                App.WeatherLabelStyle26px = "MorningEveningTheme";
                App.RectangleCity = "MorningEveningTheme";
                App.CartOneStyle = "MorningEveningTheme";
                App.CartTwoStyle = "MorningEveningTheme";
                App.CartThreeStyle = "MorningEveningTheme";
                App.WatermarkStyle = "MorningEveningTheme";
            }
            else if (hour >= 12 && hour <= 16)
            {
                App.Theme = "DayTheme";
                App.Button = "DayTheme";
                App.ButtonInWeather = "DayTheme";
                App.TextBox = "DayTheme";
                App.Label = "DayTheme";
                App.WeatherLabelStyle20px = "DayTheme";
                App.WeatherLabelStyle26px = "DayTheme";
                App.RectangleCity = "DayTheme";
                App.CartOneStyle = "DayTheme";
                App.CartTwoStyle = "DayTheme";
                App.CartThreeStyle = "DayTheme";
                App.WatermarkStyle = "DayTheme";
            }
        }
    }

}
