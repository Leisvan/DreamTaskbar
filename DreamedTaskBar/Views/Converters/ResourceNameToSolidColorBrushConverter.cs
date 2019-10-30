using DreamTaskbar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace DreamTaskbar.Views.Converters
{
    public class ResourceNameToSolidColorBrushConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string resourceName = value as string;
            if (ResourceLocator.GetThemeResource(resourceName, out SolidColorBrush brush))
            {
                return brush;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
