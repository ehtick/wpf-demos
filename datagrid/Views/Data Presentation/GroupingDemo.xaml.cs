#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace syncfusion.datagriddemos.wpf
{
    /// <summary>
    /// Interaction logic for GroupingDemo.xaml
    /// </summary>
    public partial class GroupingDemo : DemoControl
    {
        public GroupingDemo(string themename) : base(themename)
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (this.DataContext != null)
                this.DataContext = null;

            //Release all managed resources
            if (this.sfGrid != null)
            {
                this.sfGrid.Dispose();
                this.sfGrid = null;
            }

            if (this.AFC_ChkBox != null)
                this.AFC_ChkBox = null;

            if (this.Name_ChkBx != null)
                this.Name_ChkBx = null;

            base.Dispose(disposing);
        }
    }
}
