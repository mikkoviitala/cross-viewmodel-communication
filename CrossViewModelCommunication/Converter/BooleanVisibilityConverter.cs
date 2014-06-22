using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace CrossViewModelCommunication.Converter
{
    public class BooleanVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
                return (bool) value ? Visibility.Visible : Visibility.Collapsed;
            throw new ArgumentException("bool expected");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Visibility)
                return ((Visibility)value) == Visibility.Visible;
            throw new ArgumentException("Visibility expected");
        }
    }
}
