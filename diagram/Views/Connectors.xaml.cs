#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using syncfusion.demoscommon.wpf;
using syncfusion.diagramdemo.wpf.ViewModel;
using Syncfusion.UI.Xaml.Diagram;
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
    /// Interaction logic for Connectors.xaml
    /// </summary>
    public partial class Connectors : DemoControl
    {
        public Connectors()
        {           
            InitializeComponent();
        }

        public Connectors(string themename) : base(themename)
        {
            InitializeComponent();
            this.DataContext = new ConnectorsViewModel(this);
        }

        private void Diagram_Loaded(object sender, RoutedEventArgs e)
        {
            (Diagram.DataContext as ConnectorsViewModel).prevbutton = BezierConnector;
            FitToPageParameter fitToPage = new FitToPageParameter() { FitToPage = FitToPage.FitToPage, Region = Region.Content };
            (Diagram.Info as IGraphInfo).Commands.FitToPage.Execute(fitToPage);
        }

        protected override void Dispose(bool disposing)
        {
            if (this.DataContext != null)
            {
                var viewModel = Diagram.DataContext as ConnectorsViewModel;
                if (viewModel != null)
                {
                    viewModel.prevbutton = null;
                }

                this.DataContext = null;
            }

            if (this.Diagram != null)
            {
                this.Diagram = null;
            }

            Part_FillColor.Dispose();

            base.Dispose(disposing);
        }
    }
}
