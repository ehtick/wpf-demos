#region Copyright Syncfusion Inc. 2001 - 2015
// Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace syncfusion.datagriddemos.wpf
{
    /// <summary>
    /// Interaction logic for ObservableCollectionPage.xaml
    /// </summary>
    public partial class ObservableCollectionPage : Page
    {
        public ObservableCollectionPage()
        {
            InitializeComponent();
            this.Unloaded += ObservableCollectionPage_Unloaded;
        }

        private void ObservableCollectionPage_Unloaded(object sender, RoutedEventArgs e)
        {
            if(this.syncgrid != null)
            {
                this.syncgrid.Dispose();
                this.syncgrid = null;
            }

            this.Unloaded -= ObservableCollectionPage_Unloaded;
        }
    }
}
