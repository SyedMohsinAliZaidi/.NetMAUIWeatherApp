using System.Globalization;

namespace WeatherApp
{
    public class FahrenheitToCelciusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double fahrenheit = (double)value;
            double celcius = 0.00;
            if (!ReferenceEquals(fahrenheit, null)) {
                celcius = (fahrenheit - 32) * 5 / 9;
            }
            return Math.Round(celcius).ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
