using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace CrossViewModelCommunication.Converter
{
    public class StringBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var fromString = ColorConverter.ConvertFromString(value as string);
            if (fromString != null)
                return new SolidColorBrush((Color)fromString);
            
            return new SolidColorBrush(Colors.Transparent);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
