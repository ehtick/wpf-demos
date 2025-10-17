﻿using Syncfusion.SfSkinManager;
using Syncfusion.UI.Xaml.Diagram;
using Syncfusion.Windows.Shared;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace syncfusion.floorplanner.wpf
{
    /// <summary>
    /// Interaction logic for FloorPlannerDemo.xaml
    /// </summary>
    public partial class FloorPlannerDemo : ChromelessWindow
    {
        public FloorPlannerDemo()
        {
            SfSkinManager.SetTheme(this, new Theme() { ThemeName = "FluentLight" });
            InitializeComponent();

            if (this.DataContext != null)
            {
                (this.DataContext as FloorPlannerViewModel).View = this;
            }

            this.SizeChanged += FloorPlannerDemo_SizeChanged;
            this.Closing += FloorPlannerDemo_Closing;
        }

        private void FloorPlannerDemo_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.DataContext != null)
            {
                (this.DataContext as FloorPlannerViewModel).SaveCommand.Execute(null);
            }
        }

        private void FloorPlannerDemo_SizeChanged(object sender, System.Windows.SizeChangedEventArgs e)
        {
            var count = Math.Round(e.NewSize.Width / 196);
            double marginLeft = (e.NewSize.Width - (((count > 3 ? count - 2 : count - 1) * 196) + 30)) * 0.5;
            this.BackStageArea.Margin = new Thickness(marginLeft, 48, marginLeft, 48);
        }
    }

    public class SymbolCollection : ObservableCollection<NodeViewModel>
    {

    }
}
