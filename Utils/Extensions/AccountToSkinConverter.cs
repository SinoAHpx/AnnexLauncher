using System;
using System.Globalization;
using System.Windows.Data;
using AnnexLauncher.Model;

namespace AnnexLauncher.Utils.Extensions
{
    public class AccountToSkinConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is AccountModel am) 
                return am.AccountSkin;

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}