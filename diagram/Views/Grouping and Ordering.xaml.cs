#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using syncfusion.demoscommon.wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using Syncfusion.UI.Xaml.Diagram;
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

namespace syncfusion.diagramdemo.wpf.Views
{
    /// <summary>
    /// Interaction logic for Grouping_and_Ordering.xaml
    /// </summary>
    public partial class Grouping_and_Ordering : DemoControl
    {
        public Grouping_and_Ordering()
        {
            InitializeComponent();
        }

        public Grouping_and_Ordering(string themename) : base(themename)
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (this.DataContext != null)
            {
                this.DataContext = null;
            }
            if (this.Diagram != null)
            {
                this.Diagram = null;
            }
            if (this.stencil != null)
            {
                this.stencil.SymbolGroups = null;
                (this.stencil.SymbolSource as SymbolCollection).Clear();
                this.stencil = null;
            }
            base.Dispose(disposing);
        }
    }
}
