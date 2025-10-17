﻿using syncfusion.demoscommon.wpf;
using Syncfusion.UI.Xaml.TreeView.Engine;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace syncfusion.treeviewdemos.wpf
{
    /// <summary>
    /// Interaction logic for DragDropBetweenTreeViewAndListViewDemo.xaml
    /// </summary>
    public partial class DragDropBetweenTreeViewAndListViewDemo : DemoControl
    {
        public DragDropBetweenTreeViewAndListViewDemo()
        {
            InitializeComponent();
        }
		
		public DragDropBetweenTreeViewAndListViewDemo(string themename) : base(themename)
        {
            InitializeComponent();
        }
		
        protected override void Dispose(bool disposing)
        {
            // Release all managed resources
            if (this.treeView != null)
            {
                this.treeView.Dispose();
                this.treeView = null;
            } 
             
            if (this.listView != null)
                this.listView = null;

            if (this.DataContext != null)
                this.DataContext = null;


            base.Dispose(disposing);
        }
    } 
}
