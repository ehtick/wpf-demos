#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using syncfusion.demoscommon.wpf;
using Syncfusion.Windows.Shared;

namespace syncfusion.datagriddemos.wpf
{
    /// <summary>
    /// Interaction logic for AlternateRowStyleDemo.xaml
    /// </summary>
    public partial class AlternateRowStyleDemo : DemoControl
    {
        public AlternateRowStyleDemo()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (this.DataContext != null)
                this.DataContext = null;

            //Release all managed resources
            if(this.dataGrid != null)
            {
                this.dataGrid.Dispose();
                this.dataGrid = null;
            }

            if (this.textBlock1 != null)
                this.textBlock1 = null;

            if (this.textBlock2 != null)
                this.textBlock2 = null;

            if (rowBackgroundPicker != null)
                rowBackgroundPicker = null;

            if (alternatingRowBackgroundPicker != null)
                alternatingRowBackgroundPicker = null;

            base.Dispose(disposing);
        }
    }
}
