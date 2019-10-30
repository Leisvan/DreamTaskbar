using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace DreamTaskbar.Services
{
    public static class ResourceLocator
    {
        private const string DARK_KEY = "Dark";
        private const string LIGHT_KEY = "Light";

        public static bool GetThemeResource<T>(string key, out T resource)
        {
            if (string.IsNullOrEmpty(key))
            {
                resource = default;
                return false;
            }
            var theme = Application.Current.RequestedTheme;
            string themeKey = (theme == ApplicationTheme.Dark) ? DARK_KEY : LIGHT_KEY;
            var themeDictionary = (ResourceDictionary)Application.Current.Resources.ThemeDictionaries[themeKey];
            bool result = themeDictionary.ContainsKey(key);
            resource = (result) ? (T)themeDictionary[key] : default;
            return result;
        }
    }
}
