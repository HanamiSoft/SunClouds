using StylesLib;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace SunClouds.ViewModel.Helpers
{
    /// <summary>
    /// Класс-помощник для биндинга(привязки) ваших свойств из ViewModel во View, в MVVM.
    /// </summary>
    public class BindingHelper : INotifyPropertyChanged
    {
        public Dictionary<string, object> ResourcesTheme { get; set; }
        public Style ButtonStyle { get; set; }
        public Style TextBoxStyle { get; set; }
        public Style LabelStyle { get; set; }
        public Style WeatherLabelStyle20px { get; set; }
        public Style WeatherLabelStyle26px { get; set; }
        public Style TemperatureStyle { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public BindingHelper()
        {
            ButtonStyle = StylesConnect.ButtonStyle;
            ResourcesTheme = StylesConnect.ResourcesTheme;
            TextBoxStyle = StylesConnect.TextBoxStyle;
            LabelStyle = StylesConnect.LabelStyle;
            WeatherLabelStyle20px = StylesConnect.WeatherLabelStyle20px;
            WeatherLabelStyle26px = StylesConnect.WeatherLabelStyle26px;
            TemperatureStyle = StylesConnect.TemperatureStyle;
            StylesConnect.StylesConnecting();
        }
    }
}
