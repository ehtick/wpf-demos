#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.Xaml.Behaviors;
using Syncfusion.UI.Xaml.Charts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace syncfusion.surfacechartdemos.wpf
{
    class ContourandWireframeContourBehavior : Behavior<ContourandWireframeContour>
    {
        List<Data> DataValues;
        /// <summary>
        /// Called when [attached].
        /// </summary>
        protected override void OnAttached()
        {
            this.AssociatedObject.Loaded += new RoutedEventHandler(AssociatedObject_Loaded);
            DataValues = new List<Data>();
        }

        /// <summary>
        /// Handles the Loaded event of the AssociatedObject control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        void AssociatedObject_Loaded(object sender, RoutedEventArgs e)
        {
            this.AssociatedObject.surfaceChart.Loaded += OnSurfaceChart_Loaded;

        }

        private void OnSurfaceChart_Loaded(object sender, RoutedEventArgs e)
        {
            SetData();
            this.AssociatedObject.surfaceTypeComboBox.SelectionChanged += SurfaceTypeComboBox_SelectionChanged;
            this.AssociatedObject.surfaceTypeComboBox.SelectedIndex = 0;
         

        }

        private void SurfaceTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            if (this.AssociatedObject.surfaceChart != null)
            {
                if (comboBox.SelectedIndex == 0)
                    this.AssociatedObject.surfaceChart.Type = SurfaceType.Contour;
                else
                    this.AssociatedObject.surfaceChart.Type = SurfaceType.WireframeContour;
            }
        }

        private void SetData()
        {
            int x = 0;
           for (double i = -10; i <= 10; i++, x++)
            {
                int z = 0;
                for (double j = -10; j <= 10; j++, z++)
                {
                    double y = i * Math.Sin(j) + j * Math.Sin(i);
                    this.AssociatedObject.surfaceChart.Data.AddPoints(x, y, z);
                    DataValues.Add(new Data() { X = x, Y = y, Z = z });
                }

                this.AssociatedObject.surfaceChart.RowSize = 21;
                this.AssociatedObject.surfaceChart.ColumnSize = 21;
                this.AssociatedObject.surfaceChart.ItemsSource = DataValues;
            }
        }

        /// <summary>
        /// Called when [detaching].
        /// </summary>
        protected override void OnDetaching()
        {
            this.AssociatedObject.Loaded -= new System.Windows.RoutedEventHandler(AssociatedObject_Loaded);
            this.AssociatedObject.surfaceChart.Loaded -= OnSurfaceChart_Loaded;
            this.AssociatedObject.surfaceTypeComboBox.SelectionChanged -= SurfaceTypeComboBox_SelectionChanged;
            DataValues = null;
        }
    }
}
