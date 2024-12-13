#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using syncfusion.demoscommon.wpf;
using Syncfusion.SfSkinManager;
using Syncfusion.UI.Xaml.Diagram;
using Syncfusion.Windows.Shared;
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
    /// Interaction logic for Circuit_Diagram.xaml
    /// </summary>
    public partial class Circuit_Diagram : DemoControl
    {
        private bool first = true;
        public Circuit_Diagram()
        {
            InitializeComponent();
        }

        public Circuit_Diagram(string themename) : base(themename)
        {
            InitializeComponent();
            (diagram.Info as IGraphInfo).ViewPortChangedEvent += Circuit_Diagram_ViewPortChangedEvent;
        }

        private void Circuit_Diagram_ViewPortChangedEvent(object sender, ChangeEventArgs<object, ScrollChanged> args)
        {
            if (diagram.Info != null && (args.Item as SfDiagram).IsLoaded == true && first && args.NewValue.ContentBounds != args.OldValue.ContentBounds)
            {
                (diagram.Info as IGraphInfo).BringIntoCenter(args.NewValue.ContentBounds);
                first = false;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (this.DataContext != null)
            {
                this.DataContext = null;
            }

            if (this.diagram != null)
            {
                (this.diagram.Connectors as ConnectorCollection).Clear();
                (this.diagram.Nodes as NodeCollection).Clear();
                this.diagram = null;
            }
            base.Dispose(disposing);
        }
    }
}
