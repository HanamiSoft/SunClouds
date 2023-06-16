using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows.Threading;

namespace SunClouds
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        /*private static string theme;
        public static string Theme
        {
            get { return theme; }
            set
            {
                theme = value;
                var dict = new ResourceDictionary { Source = new Uri($"/SunClouds;component/Resources/{value}.xaml", UriKind.Relative) };

                if (Current.Resources.MergedDictionaries.Count > 0)
                {
                    Current.Resources.MergedDictionaries.RemoveAt(0);
                }

                Current.Resources.MergedDictionaries.Insert(0, dict);
            }
        }*/
    }
}
