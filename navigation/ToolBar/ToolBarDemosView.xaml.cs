#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using syncfusion.demoscommon.wpf;

namespace syncfusion.navigationdemos.wpf
{
    /// <summary>
    /// Interaction logic for ToolBarDemosView.xaml
    /// </summary>
    public partial class ToolBarDemosView : DemoControl
    {
        public ToolBarDemosView()
        {
            InitializeComponent();
        }

        public ToolBarDemosView(string themename) : base(themename)
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            // Release all managed resources
            if (this.toolBarManager != null)
            {
                this.toolBarManager = null;
            }
            if(toolBarGrid != null)
            {
                toolBarGrid.Children.Clear();
                toolBarGrid = null;
            }
            base.Dispose(disposing);
        }
    }
}
