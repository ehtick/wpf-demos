#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using syncfusion.demoscommon.wpf;
using Syncfusion.Windows.Shared;
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
using System.Windows.Shapes;

namespace syncfusion.layoutdemos.wpf
{
    /// <summary>
    /// Interaction logic for WindowStateRestrictionDemo.xaml
    /// </summary>
    public partial class WindowStateRestrictionDemo : DemoControl
    {
        public WindowStateRestrictionDemo()
        {
            InitializeComponent();
        }
        public WindowStateRestrictionDemo(string themename) : base(themename)
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (this.DocumentContainer != null)
            {
                this.DocumentContainer.Dispose();
                this.DocumentContainer = null;
            }

            if (this.doc != null)
            {
                this.doc = null;
            }

            if (this.firstdoc != null)
            {
                this.firstdoc = null;
            }

            if (this.seconddoc != null)
            {
                this.seconddoc = null;
            }

            if (this.ThirdDoc != null)
            {
                this.ThirdDoc = null;
            }

            base.Dispose(disposing);
        }
    }
}
