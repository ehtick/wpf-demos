#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace syncfusion.datagriddemos.wpf
{
    public class StyleConverterforQS3 : IValueConverter
    {
        internal ConditionalFormattingDemo conditionalFormattingDemo;
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (conditionalFormattingDemo == null)
                conditionalFormattingDemo = (ConditionalFormattingDemo)Activator.CreateInstance(typeof(ConditionalFormattingDemo));
            double _value;
            if (!String.IsNullOrEmpty(value as string))
            {
                _value = double.Parse(value.ToString(), NumberStyles.Currency);
                if (_value < 6600000.00 && _value > 1000000.00)
                    return conditionalFormattingDemo.Resources["Brush2"];
            }
            return new SolidColorBrush();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
