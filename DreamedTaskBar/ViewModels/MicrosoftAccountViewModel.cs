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

        public MicrosoftAccountViewModel()
        {
            LoadTestData();
        }
        public void LoadTestData()
        {
            SyncingFiles.Add(new ExtendedBundle("", "DSC1951.jpg", "Uploaded to", "Camera", "", "3h ago"));
            SyncingFiles.Add(new ExtendedBundle("", "DSC1952.jpg", "Uploaded to", "Camera", "", "3h ago"));
            SyncingFiles.Add(new ExtendedBundle("", "DSC1953.jpg", "Uploaded to", "Camera", "", "3h ago"));
        }
    }
}
