﻿#pragma checksum "..\..\..\..\..\Views\Interactive Features\CutCopyPasteDemo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ACBB3B869EF040A5CF837B3CB3B1C14B801CABE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Xaml.Behaviors;
using Microsoft.Xaml.Behaviors.Core;
using Microsoft.Xaml.Behaviors.Input;
using Microsoft.Xaml.Behaviors.Layout;
using Microsoft.Xaml.Behaviors.Media;
using Syncfusion;
using Syncfusion.SfSkinManager;
using Syncfusion.UI.Xaml.Charts;
using Syncfusion.UI.Xaml.Controls.DataPager;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Converter;
using Syncfusion.UI.Xaml.Grid.RowFilter;
using Syncfusion.UI.Xaml.ProgressBar;
using Syncfusion.UI.Xaml.TreeGrid;
using Syncfusion.UI.Xaml.TreeGrid.Filtering;
using Syncfusion.Windows;
using Syncfusion.Windows.Controls.Input;
using Syncfusion.Windows.Controls.Notification;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using syncfusion.datagriddemos.wpf;
using syncfusion.demoscommon.wpf;


namespace syncfusion.datagriddemos.wpf {
    
    
    /// <summary>
    /// CutCopyPasteDemo
    /// </summary>
    public partial class CutCopyPasteDemo : syncfusion.demoscommon.wpf.DemoControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\..\Views\Interactive Features\CutCopyPasteDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock1;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\Views\Interactive Features\CutCopyPasteDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SelectionUnit;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\Views\Interactive Features\CutCopyPasteDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock2;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\..\Views\Interactive Features\CutCopyPasteDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbSelectionMode;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\..\Views\Interactive Features\CutCopyPasteDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock3;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\..\Views\Interactive Features\CutCopyPasteDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Tools.Controls.ComboBoxAdv CopyOptionComboBox;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\..\Views\Interactive Features\CutCopyPasteDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock4;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\..\Views\Interactive Features\CutCopyPasteDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Tools.Controls.ComboBoxAdv PasteOptionComboBox;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\..\Views\Interactive Features\CutCopyPasteDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock5;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\..\Views\Interactive Features\CutCopyPasteDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Clipboardcontent;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\..\..\Views\Interactive Features\CutCopyPasteDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.UI.Xaml.Grid.SfDataGrid datagrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/syncfusion.datagriddemos.wpf;component/views/interactive%20features/cutcopypaste" +
                    "demo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Interactive Features\CutCopyPasteDemo.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.SelectionUnit = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.textBlock2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.cmbSelectionMode = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.textBlock3 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.CopyOptionComboBox = ((Syncfusion.Windows.Tools.Controls.ComboBoxAdv)(target));
            return;
            case 7:
            this.textBlock4 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.PasteOptionComboBox = ((Syncfusion.Windows.Tools.Controls.ComboBoxAdv)(target));
            return;
            case 9:
            this.textBlock5 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.Clipboardcontent = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.datagrid = ((Syncfusion.UI.Xaml.Grid.SfDataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
