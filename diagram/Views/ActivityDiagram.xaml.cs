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
using Syncfusion.UI.Xaml.Diagram.Theming;
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
using System.Windows.Shapes;

namespace syncfusion.diagramdemo.wpf.Views
{
    /// <summary>
    /// Interaction logic for ActivityDiagram.xaml
    /// </summary>
    public partial class ActivityDiagram : DemoControl
    {
        public ActivityDiagram()
        {
            InitializeComponent();
        }
        public ActivityDiagram(string themename) : base(themename)
        {
            InitializeComponent();
            SfSkinManager.SetTheme(this, new Syncfusion.SfSkinManager.Theme() { ThemeName = themename });
        }
        protected override void Dispose(bool disposing)
        {
            if (this.DataContext != null)
            {
                this.DataContext = null;
            }
            if (this.Diagram != null)
            {
                if (this.Diagram.Nodes != null)
                {
                    (this.Diagram.Nodes as NodeCollection).Clear();
                }
                if (this.Diagram.Connectors != null)
                {
                    (this.Diagram.Connectors as ConnectorCollection).Clear();
                }
                if (this.Diagram.Groups != null)
                {
                    (this.Diagram.Groups as GroupCollection).Clear();
                }
                this.Diagram.HorizontalRuler = null;
                this.Diagram.VerticalRuler = null;
                this.Diagram = null;
            }
            if (this.stencil != null)
            {
                this.stencil.SymbolGroups = null;
                (this.stencil.SymbolSource as SymbolCollection).Clear();
                this.stencil.DataContext = null;
                this.stencil = null;
            }

            base.Dispose(disposing);
        }
    }
}
