using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridExample.Views.Converters
{
    public class TermScoreToSolidColorBrush : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if(value == null) return null;

            if(value is float score)
            {
                if(score < 1.0)
                {
                    return Brushes.Red;
                }
                else if(score < 1.5)
                {
                    return Brushes.LightGoldenrodYellow;
                }

                return Brushes.Green;
            }

            return null;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
