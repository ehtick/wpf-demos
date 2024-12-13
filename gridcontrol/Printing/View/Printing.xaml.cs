#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Syncfusion.Windows.Shared;
using System.ComponentModel;
using Syncfusion.Windows.Controls.Grid;
using System.IO;
using System.Reflection;
using Syncfusion.Windows.GridCommon;
using syncfusion.demoscommon.wpf;

namespace syncfusion.gridcontroldemos.wpf
{
    /// <summary>
    /// Interaction logic for Printing.xaml
    /// </summary>
    public partial class Printing : DemoControl
    {
        //DataSourceDataContext northWind; 
        public Printing()
        {
            InitializeComponent();
            this.gc.Model.RowCount = 30;
            this.gc.Model.ColumnCount = 20;
            this.gc.Model.QueryCellInfo += (s, e) =>
            {
                if (e.Cell.RowIndex > 0 && e.Cell.ColumnIndex > 0)
                    e.Style.CellValue = string.Format("R{0}C{1}", e.Cell.RowIndex, e.Cell.ColumnIndex);
            };
            //this.gc.Model.ColumnWidths[0] = 80;
            this.gc.ColumnWidths[0] = 30d;
            
        }
        public Printing(string themename) : base(themename)
        {
            InitializeComponent();
            this.gc.Model.RowCount = 30;
            this.gc.Model.ColumnCount = 20;
            this.gc.Model.QueryCellInfo += (s, e) =>
            {
                if (e.Cell.RowIndex > 0 && e.Cell.ColumnIndex > 0)
                    e.Style.CellValue = string.Format("R{0}C{1}", e.Cell.RowIndex, e.Cell.ColumnIndex);
            };
            //this.gc.Model.ColumnWidths[0] = 80;
            this.gc.ColumnWidths[0] = 30d;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.gc.ShowPrintDialog();
        }

        protected override void Dispose(bool disposing)
        {
            if (this.gc != null)
            {
                this.gc.Dispose();
                this.gc = null;
            }
            base.Dispose(disposing);
        }
    }
}
