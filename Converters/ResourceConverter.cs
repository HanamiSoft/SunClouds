using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace SunClouds.Converters
{
    public class ResourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string resourcePath)
            {
                var resourceDictionary = new ResourceDictionary
                {
                    Source = new Uri(resourcePath, UriKind.Relative)
                };
                var backgroundBrush = resourceDictionary["BackgroundTheme"] as ImageBrush;
                return backgroundBrush;
            }

            return DependencyProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
