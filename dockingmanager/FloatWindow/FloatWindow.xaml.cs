#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using syncfusion.demoscommon.wpf;
using Syncfusion.SfSkinManager;
using Syncfusion.Windows.Shared;
using System;

namespace syncfusion.dockingmanagerdemos.wpf
{
    /// <summary>
    /// Interaction logic for ScrollableAutoHiddenPanel.xaml
    /// </summary>
    public partial class FloatWindow : DemoControl
    {
        public FloatWindow()
        {
            InitializeComponent();
        }

        public FloatWindow(string themename) : base(themename)
        {
            InitializeComponent();
        }
        protected override void Dispose(bool disposing)
        {
            //Release all managed resources
            if (this.dockingManager != null)
            {
                this.dockingManager.Dispose();
                this.dockingManager = null;
            }

            if (this.ComboBoxAdv != null)
            {
                this.ComboBoxAdv.Dispose();
                this.ComboBoxAdv = null;
            }

            base.Dispose(disposing);
        }
    }
}
