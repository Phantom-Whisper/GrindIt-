using System;
using System.Globalization;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Controls;

namespace GrindIt_.Resources.Converters
{
    public class IntensityToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int intensity = (int)value;
            return intensity switch
            {
                1 => Colors.LightGreen,
                2 => Colors.Green,
                3 => Colors.DarkGreen,
                4 => Colors.SeaGreen,
                5 => Colors.DarkOliveGreen,
                _ => Colors.LightGray
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}