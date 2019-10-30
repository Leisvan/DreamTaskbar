using DreamTaskbar.Models;
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
        }
    }
}
