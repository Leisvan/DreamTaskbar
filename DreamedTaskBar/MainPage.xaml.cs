using DreamTaskbar.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UniversalPlatformTools;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DreamTaskbar
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        public MainPage()
        {
            this.InitializeComponent();
            SetupUI();
        }

        public void SetupUI()
        {
            CoreApplicationViewTitleBar coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            coreTitleBar.ExtendViewIntoTitleBar = true;

            ApplicationView.PreferredLaunchViewSize = new Size { Width = 800, Height = 800 };
            var view = ApplicationView.GetForCurrentView();
            view.SetPreferredMinSize(new Size { Width = 1000, Height = 800 });

            var titleBar = ApplicationView.GetForCurrentView().TitleBar;

            var theme = (Application.Current.RequestedTheme == ApplicationTheme.Dark)
                ? ElementTheme.Dark : ElementTheme.Light;
            titleBar.BackgroundColor = Colors.Transparent;
            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.ButtonForegroundColor = GetThemeResource<Color>(theme, "TitleBarButtonForeground");
            titleBar.ButtonHoverBackgroundColor = GetThemeResource<Color>(theme, "TitleBarButtonHoverBackground");
            titleBar.ButtonHoverForegroundColor = GetThemeResource<Color>(theme, "TitleBarButtonHoverForeground");
            //Inactive
            titleBar.InactiveBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveForegroundColor = GetThemeResource<Color>(theme, "TitleBarButtonForeground");
        }

        private static T GetThemeResource<T>(ElementTheme theme, string resKey)
        {
            bool isLightTheme = (theme == ElementTheme.Default)
                ? (SystemHelper.GetSystemTheme() == SystemTheme.Light)
                : (theme == ElementTheme.Light);
            string themeKey = isLightTheme ? "Light" : "Dark";
            var themeDictionary = (ResourceDictionary)Application.Current.Resources.ThemeDictionaries[themeKey];
            return (T)themeDictionary[resKey];
        }

        private async void WhatsNewClick(object sender, RoutedEventArgs e)
        {
            WhatsNewButton.Visibility = Visibility.Collapsed;
            WhatsNewDialog dialog = new WhatsNewDialog();
            await dialog.ShowAsync();
        }
    }
}
