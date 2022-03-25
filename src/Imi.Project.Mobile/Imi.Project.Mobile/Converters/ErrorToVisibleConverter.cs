using System;
using System.Globalization;
using Xamarin.Forms;

namespace Imi.Project.Mobile.Converters
{
    public class ErrorToVisibleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if (value is string)
                {
                    string errorMessage = value as string;
                    return !string.IsNullOrEmpty(errorMessage);
                }
                else
                {
                    throw new ArgumentException($"{nameof(value)} must be a string");
                }
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
