using DreamTaskbar.Models;
using DreamTaskbar.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamTaskbar.ViewModels
{
    public class MicrosoftAccountViewModel
    {
        public ObservableCollection<ExtendedBundle> SyncingFiles
        {
            get;
            set;
        } = new ObservableCollection<ExtendedBundle>();
        public ObservableCollection<ExtendedBundle> OfficePinnedFiles
        {
            get;
            set;
        } = new ObservableCollection<ExtendedBundle>();
        public ObservableCollection<ExtendedBundle> OfficeRecentFiles
        {
            get;
            set;
        } = new ObservableCollection<ExtendedBundle>();
        public ObservableCollection<ExtendedBundle> AccountNotifications
        {
            get;
            set;
        } = new ObservableCollection<ExtendedBundle>();

        public MicrosoftAccountViewModel()
        {
            LoadTestData();
        }
        public void LoadTestData()
        {
            //OneDrive Syncing Files
            SyncingFiles.Add(new ExtendedBundle("", "DSC1951.jpg", "Uploaded to", "Camera", "", "3h ago"));
            SyncingFiles.Add(new ExtendedBundle("", "DSC1952.jpg", "Uploaded to", "Camera", "", "3h ago"));
            SyncingFiles.Add(new ExtendedBundle("", "DSC1953.jpg", "Uploaded to", "Camera", "", "3h ago"));
            SyncingFiles.Add(new ExtendedBundle("", "Last report.docx", "Uploaded to", "Documents", "", "6h ago"));

            //Office Files
            OfficePinnedFiles.Add(new ExtendedBundle("", "Ants report", "OneDrive » Documents » Reports", null, "", null, "WordForeground"));

            OfficeRecentFiles.Add(new ExtendedBundle("", "Draft for Tuesday", "OneDrive » Documents » Reports", null, null, null, "WordForeground"));
            OfficeRecentFiles.Add(new ExtendedBundle("", "Numbers to sum", "OneDrive » Documents » Extras", null, "", null, "ExcelForeground"));
            OfficeRecentFiles.Add(new ExtendedBundle("", "Squares and lines", "OneDrive » Documents » Extras", null, "", null, "ExcelForeground"));
            OfficeRecentFiles.Add(new ExtendedBundle("", "Mockup Presentation", "OneDrive » Documents » Work", null, "", null, "PowerPointForeground"));

            //Account notifications
            AccountNotifications.Add(new ExtendedBundle(GlyphEncoder.EncodeGlyph("", GlyphFamily.FabricMDL2), "New Canary build for", "Edge", "Microsoft Edge Insider", null, "Just now", "EdgeCanaryForeground"));
            AccountNotifications.Add(new ExtendedBundle(GlyphEncoder.EncodeGlyph("", GlyphFamily.SegoeMDL2), "New Insider build available", "10.0.21200", "Windows Insider Program", null, "Yesterday", "PowerPointForeground"));
            AccountNotifications.Add(new ExtendedBundle(GlyphEncoder.EncodeGlyph("", GlyphFamily.FabricMDL2), "Monthly recommended apps", "", "Microsoft Store", null, "2d ago", ""));
        }
    }
}
