#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using syncfusion.demoscommon.wpf;
namespace syncfusion.layoutdemos.wpf
{
    /// <summary>
    /// Interaction logic for DataBinding.xaml
    /// </summary>
    public partial class DataBindingDemo : DemoControl
    {
        public DataBindingDemo()
        {
            InitializeComponent();
        }
        public DataBindingDemo(string themename):base(themename)
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (this.tileViewControl != null)
            {
                this.tileViewControl.Dispose();
                this.tileViewControl = null;
            }

            var viewModel = this.DataContext as DataBindingViewModel;
            if (viewModel != null)
            {
                viewModel.Applications = null;
            }

            this.DataContext = null;
            base.Dispose(disposing);
        }
    }
}
