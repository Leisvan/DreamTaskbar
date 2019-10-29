using DreamTaskbar.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamTaskbar.ViewModels
{
    public class BluetoothPeekViewModel
    {
        public ObservableCollection<IconTitleSubtitleBundle> BluetoothDevices
        {
            get;
            set;
        } = new ObservableCollection<IconTitleSubtitleBundle>();

        public BluetoothPeekViewModel()
        {
            LoadTestData();
        }

        public void LoadTestData()
        {
            BluetoothDevices.Add(new IconTitleSubtitleBundle("", "XBox Wireless Controller", "Connected", "", "63%"));
            BluetoothDevices.Add(new IconTitleSubtitleBundle("", "Corair HS70 Wireless Gaming Headset", "Paired"));
            BluetoothDevices.Add(new IconTitleSubtitleBundle("", "Samsung 6 Series"));
            BluetoothDevices.Add(new IconTitleSubtitleBundle("", "Microsoft Surface Mouse", "Paired", "", "98%"));
            BluetoothDevices.Add(new IconTitleSubtitleBundle("", "Surface Pen", "Paired", "", "91%"));
            BluetoothDevices.Add(new IconTitleSubtitleBundle("", "Surface Type Cover"));

        }
    }
}
