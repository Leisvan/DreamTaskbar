using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamTaskbar.Services
{
    public class GlyphEncoder
    {
        private const string FAMILYNAME_SEGOE = "SEG";
        private const string FAMILYNAME_FABRIC = "FAB";
        private const string FAMILYNAME_MATERIAL = "MAT";
        private const string SEPARATOR = "-";
        public static Dictionary<GlyphFamily, string> _nameTable;
        static GlyphEncoder()
        {
            _nameTable = new Dictionary<GlyphFamily, string>
            {
                { GlyphFamily.SegoeMDL2, FAMILYNAME_SEGOE },
                { GlyphFamily.FabricMDL2, FAMILYNAME_FABRIC },
                { GlyphFamily.MaterialDesign, FAMILYNAME_MATERIAL }
            };
        }

        public static string EncodeGlyph(string glyph, GlyphFamily family)
        {
            string name = _nameTable[family];
            return $"{name}{SEPARATOR}{glyph}";
        }
        public static string DecodeGlyph(string encodedGlyph, out GlyphFamily family)
        {
            string[] values = encodedGlyph.Split(SEPARATOR);
            if (values.Length == 2 && _nameTable.ContainsValue(values[0]))
            {
                string f = values[0];
                var pair = _nameTable.First(x => StringComparer.Ordinal.Equals(x.Value, f));
                family = pair.Key;
                return values[1];
            }
            throw new FormatException("Invalid format for input encoded glyph");
        }
    }
    public enum GlyphFamily
    {
        SegoeMDL2,
        FabricMDL2,
        MaterialDesign,
    }
}
