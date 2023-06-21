using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SunClouds
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Theme = "DayTheme";
        }

        private static string theme;
        public static string Theme
        {
            get { return theme; }
            set
            {
                theme = value;
                var dict = new ResourceDictionary { Source = new Uri($"/StylesLib;component/Resources/{value}.xaml", UriKind.Relative) };

                if (Current.Resources.MergedDictionaries.Count > 0)
                {
                    Current.Resources.MergedDictionaries.RemoveAt(0);
                }

                Current.Resources.MergedDictionaries.Insert(0, dict);
            }
        }

        private static string rectangleCity;
        public static string RectangleCity
        {
            get { return rectangleCity; }
            set
            {
                rectangleCity = value;
                var dict = new ResourceDictionary { Source = new Uri($"/StylesLib;component/Resources/{value}.xaml", UriKind.Relative) };

                if (Current.Resources.MergedDictionaries.Count > 0)
                {
                    Current.Resources.MergedDictionaries.RemoveAt(0);
                }

                Current.Resources.MergedDictionaries.Insert(0, dict);
            }
        }

        private static string button;
        public static string Button
        {
            get { return button; }
            set
            {
                button = value;
                var dict = new ResourceDictionary { Source = new Uri($"/StylesLib;component/Resources/{value}.xaml#CustomButton", UriKind.Relative) };

                if (Current.Resources.MergedDictionaries.Count > 0)
                {
                    Current.Resources.MergedDictionaries.RemoveAt(0);
                }

                Current.Resources.MergedDictionaries.Insert(0, dict);
            }
        }

        public static string ButtonInWeather
        {
            get { return button; }
            set
            {
                button = value;
                var dict = new ResourceDictionary { Source = new Uri($"/StylesLib;component/Resources/{value}.xaml#CustomButtonInWeather", UriKind.Relative) };

                if (Current.Resources.MergedDictionaries.Count > 0)
                {
                    Current.Resources.MergedDictionaries.RemoveAt(0);
                }

                Current.Resources.MergedDictionaries.Insert(0, dict);
            }
        }

        private static string textbox;
        public static string TextBox
        {
            get { return textbox; }
            set
            {
                textbox = value;
                var dict = new ResourceDictionary { Source = new Uri($"/StylesLib;component/Resources/{value}.xaml#TextControl", UriKind.Relative) };

                if (Current.Resources.MergedDictionaries.Count > 0)
                {
                    Current.Resources.MergedDictionaries.RemoveAt(0);
                }

                Current.Resources.MergedDictionaries.Insert(0, dict);
            }
        }

        private static string label;
        public static string Label
        {
            get { return label; }
            set
            {
                label = value;
                var dict = new ResourceDictionary { Source = new Uri($"/StylesLib;component/Resources/{value}.xaml#CityTitle", UriKind.Relative) };

                if (Current.Resources.MergedDictionaries.Count > 0)
                {
                    Current.Resources.MergedDictionaries.RemoveAt(0);
                }

                Current.Resources.MergedDictionaries.Insert(0, dict);
            }
        }

        private static string weatherLabelStyle20px;
        public static string WeatherLabelStyle20px
        {
            get { return weatherLabelStyle20px; }
            set
            {
                weatherLabelStyle20px = value;
                var dict = new ResourceDictionary { Source = new Uri($"/StylesLib;component/Resources/{value}.xaml#WeatherText20px", UriKind.Relative) };

                if (Current.Resources.MergedDictionaries.Count > 0)
                {
                    Current.Resources.MergedDictionaries.RemoveAt(0);
                }

                Current.Resources.MergedDictionaries.Insert(0, dict);
            }
        }

        private static string weatherLabelStyle26px;
        public static string WeatherLabelStyle26px
        {
            get { return weatherLabelStyle26px; }
            set
            {
                weatherLabelStyle26px = value;
                var dict = new ResourceDictionary { Source = new Uri($"/StylesLib;component/Resources/{value}.xaml#WeatherText26px", UriKind.Relative) };

                if (Current.Resources.MergedDictionaries.Count > 0)
                {
                    Current.Resources.MergedDictionaries.RemoveAt(0);
                }

                Current.Resources.MergedDictionaries.Insert(0, dict);
            }
        }

        private static string temperatureStyle;
        public static string TemperatureStyle
        {
            get { return temperatureStyle; }
            set
            {
                temperatureStyle = value;
                var dict = new ResourceDictionary { Source = new Uri($"/StylesLib;component/Resources/{value}.xaml#TemperatureStyle", UriKind.Relative) };

                if (Current.Resources.MergedDictionaries.Count > 0)
                {
                    Current.Resources.MergedDictionaries.RemoveAt(0);
                }

                Current.Resources.MergedDictionaries.Insert(0, dict);
            }
        }
    }
}

