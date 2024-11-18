#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.SfSkinManager;
using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace syncfusion.datagriddemos.wpf
{
    public class ChangeForegroundConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo info)
        {
            var data = value as double?;
            if ((parameter as string) != null && parameter.ToString() == "ConditionalFormattingDemo")
            {
                if (data != null && data > 3000000.00)
                    return new SolidColorBrush(Colors.Green);
                else
                    return new SolidColorBrush(Colors.Red);
            }
            else
            {
                var theme = SfSkinManager.GetTheme(parameter as SfDataGrid);
                if (theme != null && theme.ThemeName.Equals("Windows11Light"))
                {
                    if (data < 0.0)
                        return new SolidColorBrush(Color.FromRgb(196, 43, 28));
                    else
                        return new SolidColorBrush(Color.FromRgb(15, 123, 15));
                }
                else if (theme != null && theme.ThemeName.Equals("Windows11Dark"))
                {

                    if (data < 0.0)
                        return new SolidColorBrush(Color.FromRgb(255, 153, 164));
                    else
                        return new SolidColorBrush(Color.FromRgb(108, 203, 95));

                }
                else
                {
                    if (data < 0.0)
                        return new SolidColorBrush(Colors.Red);
                    else
                        return new SolidColorBrush(Colors.Green);
                }
            }
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo info)
        {
            throw new NotImplementedException();
        }
    }
}
