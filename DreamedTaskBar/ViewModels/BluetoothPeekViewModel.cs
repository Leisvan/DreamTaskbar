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
        public ObservableCollection<CommonInfoBundle> BluetoothDevices
        {
            get;
            set;
        } = new ObservableCollection<CommonInfoBundle>();

        public BluetoothPeekViewModel()
        {
            LoadTestData();
        }

        public void LoadTestData()
        {
            BluetoothDevices.Add(new CommonInfoBundle("", "XBox Wireless Controller", "Connected", "", "63%"));
            BluetoothDevices.Add(new CommonInfoBundle("", "Corair HS70 Wireless Gaming Headset", "Paired"));
            BluetoothDevices.Add(new CommonInfoBundle("", "Samsung 6 Series"));
            BluetoothDevices.Add(new CommonInfoBundle("", "Microsoft Surface Mouse", "Paired", "", "98%"));
            BluetoothDevices.Add(new CommonInfoBundle("", "Surface Pen", "Paired", "", "91%"));
            BluetoothDevices.Add(new CommonInfoBundle("", "Surface Type Cover"));

        }
    }
}
