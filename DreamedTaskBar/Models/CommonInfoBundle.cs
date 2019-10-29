// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DreamTaskbar.Models
{
    public class CommonInfoBundle
    {
        public string IconInfo { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string StatusIconInfo { get; set; }
        public string StatusText { get; set; }

        public CommonInfoBundle(string infoInfo, string title, string subtitle = null, string statusIconInfo = null, string statusText=null)
        {
            IconInfo = infoInfo;
            Title = title;
            Subtitle = subtitle;
            StatusIconInfo = statusIconInfo;
            StatusText = statusText;
        }
    }
}
