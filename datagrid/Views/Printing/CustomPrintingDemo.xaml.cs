#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using syncfusion.demoscommon.wpf;
using Syncfusion.Windows.Shared;

namespace syncfusion.datagriddemos.wpf 
{
    /// <summary>
    /// Interaction logic for CustomPrintingDemo.xaml
    /// </summary>
    public partial class CustomPrintingDemo : DemoControl
    {
        public CustomPrintingDemo(string themename) : base(themename)
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            this.Resources.Clear();

            //Release all managed resources
            if (this.syncgrid != null)
            {
                this.syncgrid.Dispose();
                this.syncgrid = null;
            }

            if (this.DataContext != null)
                this.DataContext = null;

            if (this.AllowPrintByDrawingCkb != null)
                this.AllowPrintByDrawingCkb = null;

            if (this.button != null)
                this.button = null;

            base.Dispose(disposing);
        }
    }
}
