#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using syncfusion.demoscommon.wpf;
using syncfusion.diagramdemo.wpf.ViewModel;
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

namespace syncfusion.diagramdemo.wpf.Views
{
    /// <summary>
    /// Interaction logic for OrganizationLayout.xaml
    /// </summary>
    public partial class OrganizationLayout : DemoControl
    {
        public OrganizationLayout()
        {
            InitializeComponent();
        }

        public OrganizationLayout(string themename) : base(themename)
        {
            InitializeComponent();
            (this.DataContext as OrganizationLayoutViewModel).View = this;
        }

        private void Sfdiagram_Loaded(object sender, RoutedEventArgs e)
        {
            (sfdiagram.DataContext as OrganizationLayoutViewModel).prevbutton = orgCompactAlternate;
        }

        protected override void Dispose(bool disposing)
        {
            if (this.DataContext != null)
            {
                this.DataContext = null;
            }
            if (this.sfdiagram != null)
            {
                this.sfdiagram = null;
            }
            base.Dispose(disposing);
        }
    }
}
