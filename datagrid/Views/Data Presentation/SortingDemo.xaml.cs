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
using syncfusion.demoscommon.wpf;
using Syncfusion.Windows.Shared;

namespace syncfusion.datagriddemos.wpf
{
    /// <summary>
    /// Interaction logic for SortingDemo.xaml
    /// </summary>
    public partial class SortingDemo : DemoControl
    {
        public SortingDemo(string themename) : base(themename)
        {
            InitializeComponent();           
        }

        protected override void Dispose(bool disposing)
        {
            //Release all managed resources
            if (this.dataGrid != null)
            {
                if (this.DataContext != null)
                    this.DataContext = null;

                this.dataGrid.Dispose();
                this.dataGrid = null;
            }

            if (this.CkbAllowSort != null)
                this.CkbAllowSort = null;

            if (this.CkbCustomerId != null)
                this.CkbCustomerId = null;

            if (this.CkbEnableTriStateSorting != null)
                this.CkbEnableTriStateSorting = null;

            if (this.CkbShowSortNumbers != null)
                this.CkbShowSortNumbers = null;

            if (this.CkbOrderId != null)
                this.CkbOrderId = null;

            if (this.CmbSortClickAction != null)
                this.CmbSortClickAction = null;

            if (this.textBlock != null)
                this.textBlock = null;

            base.Dispose(disposing);
        }
    }
}
