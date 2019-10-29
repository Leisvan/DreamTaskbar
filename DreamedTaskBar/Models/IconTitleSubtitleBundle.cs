// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DreamTaskbar.Models
{
    public class IconTitleSubtitleBundle
    {
        public string Glyph { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string StatusGlyph { get; set; }
        public string StatusText { get; set; }


        public IconTitleSubtitleBundle(string glyph, string title, string subtitle = null, string statusGlyph = null, string statusText=null)
        {
            Glyph = glyph;
            Title = title;
            Subtitle = subtitle;
            StatusGlyph = statusGlyph;
            StatusText = statusText;
        }
    }
}
