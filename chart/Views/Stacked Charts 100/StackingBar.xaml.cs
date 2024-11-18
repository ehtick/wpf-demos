#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using syncfusion.demoscommon.wpf;
using Syncfusion.UI.Xaml.Charts;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace syncfusion.chartdemos.wpf
{
    /// <summary>
    /// Interaction logic for StackingBar100ChartDemo.xaml
    /// </summary>
    public partial class StackingBar100ChartDemo : DemoControl
    {
        public StackingBar100ChartDemo()
        {
            InitializeComponent();
            var colorModel = new ChartColorModel();
            var customBrushes = new List<Brush>();

            customBrushes.Add(new SolidColorBrush(Color.FromArgb(0xFF, 0x77, 0x5D, 0xD0)));
            customBrushes.Add(new SolidColorBrush(Color.FromArgb(0xFF, 0xF5, 0x8A, 0x3C)));
            customBrushes.Add(new SolidColorBrush(Color.FromArgb(0xFF, 0x00, 0xAE, 0xE0)));
            customBrushes.Add(new SolidColorBrush(Color.FromArgb(0xFF, 0x96, 0xD7, 0x59)));

            colorModel.CustomBrushes = customBrushes;
            StackingBar100Chart.ColorModel = colorModel;
            StackingBar100Chart.Palette = ChartColorPalette.Custom;
        }

        protected override void Dispose(bool disposing)
        {
            StackingBar100Chart.Dispose();
            base.Dispose(disposing);
        }
        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://www.counterpointresearch.com/global-electric-vehicle-market-share/") { UseShellExecute = true });
        }
    } 
}
