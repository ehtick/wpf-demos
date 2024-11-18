#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using syncfusion.demoscommon.wpf;

namespace syncfusion.editordemos.wpf
{
    /// <summary>
    /// Interaction logic for MaskedEditDemo.xaml
    /// </summary>
    public partial class MaskedEditDemo : DemoControl
    {
        /// <summary>
        /// Constructor for MaskedEditDemo.
        /// </summary>

        public MaskedEditDemo()
        {
            InitializeComponent(); 
        }

        public MaskedEditDemo(string themename) : base(themename)
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if(validationModes!=null)
            {
                validationModes.Dispose();
                validationModes = null;
            }
            base.Dispose(disposing);
        }
    }
}
