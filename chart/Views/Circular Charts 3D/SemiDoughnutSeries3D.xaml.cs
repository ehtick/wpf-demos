#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using syncfusion.demoscommon.wpf;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace syncfusion.chartdemos.wpf
{
    /// <summary>
    /// Interaction logic for DoughnutSeriesDemo3D.xaml
    /// </summary>
    public partial class SemiDoughnutSeries3D : DemoControl
    {
        public SemiDoughnutSeries3D()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (this.doughnutChart != null)
            {
                this.doughnutChart.Dispose();
            }

            base.Dispose(disposing);
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://downloads.usda.library.cornell.edu/usda-esmis/files/zs25x844t/1j92hq475/wm1195416/grain.pdf") { UseShellExecute = true });
        }
    }
}
