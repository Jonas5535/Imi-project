using System;
using System.Globalization;
using Xamarin.Forms;

namespace Imi.Project.Mobile.Converters
{
    public class BoolToYesNoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isTrue)
            {
                string stringValue;

                if (isTrue)
                {
                    stringValue = "Ja";
                }
                else
                {
                    stringValue = "Nee";
                }
                return stringValue;
            }
            throw new ArgumentException($"{nameof(value)} must be of value bool");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
