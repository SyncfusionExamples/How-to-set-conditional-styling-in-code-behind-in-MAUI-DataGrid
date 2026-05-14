using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SfDataGridSample
{

    public class IsDeletedToColorConverter : IValueConverter
    {
        public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is OrderInfo order && order.IsDeleted)
                return Colors.LightPink;

            return Colors.Transparent;
        }

        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
            => throw new NotImplementedException();
    }

}
