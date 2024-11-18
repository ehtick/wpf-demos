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
    /// Interaction logic for GettingStarted.xaml
    /// </summary>
    public partial class GettingStarted : DemoControl
    {
        /// <summary>
        /// Initializes the new instance of <see cref="GettingStarted"/> class.
        /// </summary>
        public GettingStarted()
        {
            InitializeComponent();
        }

        public GettingStarted(string themename) : base(themename)
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            // Release all managed resources
            if (this.accordion != null)
            {
                this.accordion = null;
            }
            if (this.selectionModeTextBlock != null)
                this.selectionModeTextBlock = null;
            if (this.selectionModeComboBox != null)
                this.selectionModeComboBox = null;
            base.Dispose(disposing);
        }
    }
}
