#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
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
using Syncfusion.Windows.Shared;
using Syncfusion.UI.Xaml.TreeGrid.Converter;
using Syncfusion.Pdf.Grid;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;
using syncfusion.demoscommon.wpf;

namespace syncfusion.treegriddemos.wpf
{
    /// <summary>
    /// Interaction logic for PDFExportingDemo.xaml
    /// </summary>
    public partial class PDFExportingDemo : DemoControl
    {
        public PDFExportingDemo(string themename) : base(themename)
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            // Release all managed resources
            if (this.treeGrid != null)
            {
                this.treeGrid.Dispose();
                this.treeGrid = null;
            }

            if (this.DataContext != null)
            {
                var dataContext = this.DataContext as EmployeeInfoViewModel;
                dataContext.Dispose();
                this.DataContext = null;
            }

            if (this.autoRowHeight != null)
                this.autoRowHeight = null;

            if (this.autoColumnWidth != null)
                this.autoColumnWidth = null;

            if (this.exportFormat != null)
                this.exportFormat = null;

            if (this.repeatHeader != null)
                this.repeatHeader = null;

            if (this.fitAllColumns != null)
                this.fitAllColumns = null;

            if (this.pageHeaderandFooter != null)
                this.pageHeaderandFooter = null;

            if (this.customizeColumns != null)
                this.customizeColumns = null;

            if (this.button != null)
                this.button = null;

            base.Dispose(disposing);
        }
    }
}
