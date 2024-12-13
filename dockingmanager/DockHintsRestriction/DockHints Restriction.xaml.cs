#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using syncfusion.demoscommon.wpf;

namespace syncfusion.dockingmanagerdemos.wpf
{
    /// <summary>
    /// Interaction logic for DockHintsRestrictionDemo.xaml
    /// </summary>
    public partial class DockHintsRestrictionDemo : DemoControl
    {
        public DockHintsRestrictionDemo()
        {
            InitializeComponent();
        }

        public DockHintsRestrictionDemo(string themename) : base(themename)
        {
            InitializeComponent();
        }
        protected override void Dispose(bool disposing)
        {
            //Release all managed resources
            DockHintsBehaviors.Dispose();
            base.Dispose(disposing);
        }
    }
}
