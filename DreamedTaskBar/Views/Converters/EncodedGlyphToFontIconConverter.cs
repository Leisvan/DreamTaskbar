using DreamTaskbar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace DreamTaskbar.Views.Converters
{
    public class EncodedGlyphToFontIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string encodedGlyph = value.ToString();
            string glyph = GlyphEncoder.DecodeGlyph(encodedGlyph, out GlyphFamily family);
            FontIcon icon = new FontIcon
            {
                Glyph = glyph,
            };
            string resourceName = GetFontIconStyleResourceName(family);
            if (!string.IsNullOrWhiteSpace(resourceName) && ResourceLocator.GetResource(resourceName, out Style fontStyle))
            {
                icon.Style = fontStyle;
            }
            if (parameter != null && double.TryParse(parameter.ToString(), out double fontSize))
            {
                icon.FontSize = fontSize;
            }
            return icon;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }

        private string GetFontIconStyleResourceName(GlyphFamily family)
        {
            switch (family)
            {
                default:
                case GlyphFamily.SegoeMDL2: return string.Empty;
                case GlyphFamily.FabricMDL2: return "FabricExtFontIcon";
                case GlyphFamily.MaterialDesign: return "MaterialDesignFontIcon";
            }
        }
    }
}
