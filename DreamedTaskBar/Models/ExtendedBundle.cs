using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamTaskbar.Models
{
    public class ExtendedBundle: CommonInfoBundle
    {
        public string Caption
        {
            get;
            set;
        }
        public ExtendedBundle(string glyph, string title, string subtitle = null, string caption=null, string statusGlyph = null, string statusText = null)
            :base(glyph, title, subtitle, statusGlyph, statusText)
        {
            Caption = caption;
        }
    }
}
