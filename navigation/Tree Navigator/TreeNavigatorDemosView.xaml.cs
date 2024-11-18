#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion


namespace syncfusion.navigationdemos.wpf
{
    /// <summary>
    /// Interaction logic for TreeNavigatorDemosView.xaml
    /// </summary>
    public partial class TreeNavigatorDemosView 
    {
        public TreeNavigatorDemosView()
        {
            InitializeComponent();
        }

        public TreeNavigatorDemosView(string themename) : base(themename)
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            // Release all managed resources
            if (this.treeNavigator != null)
            {
                this.treeNavigator.Dispose();
                this.treeNavigator = null;
            }
            if (this.navigationMode != null)
            {
                this.navigationMode = null;
            }
            if (this.navigationTextBlock != null)
            {
                this.navigationTextBlock = null;
            }
            if (this.grid1 != null) 
            {
                grid1 = null;   
            }
            if (this.grid2 != null)
            {
                grid2 = null;   
            }

            base.Dispose(disposing);
        }
    }
}
