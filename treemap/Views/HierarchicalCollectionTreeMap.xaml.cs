#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using syncfusion.demoscommon.wpf;
using System;
using Syncfusion.SfSkinManager;
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

namespace syncfusion.treemapdemos.wpf
{
    /// <summary>
    /// Interaction logic for HierarchicalCollectionTreeMap.xaml
    /// </summary>
    public partial class HierarchicalCollectionTreeMap : DemoControl
    {
        public HierarchicalCollectionTreeMap()
        {
            InitializeComponent();
        }

        public HierarchicalCollectionTreeMap(string themename) : base(themename)
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (treemap != null)
            {
                treemap.Dispose();
                treemap = null;
            }

            base.Dispose(disposing);
        }
    }
}
