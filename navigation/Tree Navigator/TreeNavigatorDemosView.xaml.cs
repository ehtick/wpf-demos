﻿

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
                grid1.Children.Clear();
                grid1 = null;   
            }
            if (this.grid2 != null)
            {
                grid2.Children.Clear();
                grid2 = null;   
            }
           var viewmodel = this.DataContext as TreeNavigatorViewModel;
           if(viewmodel!=null)
           {
                viewmodel.Dispose();
           }

            base.Dispose(disposing);
        }
    }
}
