using System;
using System.Globalization;
using Xamarin.Forms;

namespace Imi.Project.Mobile.Converters
{
    public class ValueToValueWithParamConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string valueWithUnit = $"{value} {parameter}";
            return valueWithUnit;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
