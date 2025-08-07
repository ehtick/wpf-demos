#region Copyright Syncfusion Inc. 2001 - 2020
// Copyright Syncfusion Inc. 2001 - 2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

namespace syncfusion.olapchartdemos.wpf
{
    using System;
    using Syncfusion.Windows.Chart.Olap;
    using System.Windows.Controls;
    using Syncfusion.Windows.Chart;
    using Microsoft.Xaml.Behaviors;

    class ComboBoxSelectionChangedAction : TargetedTriggerAction<OlapChart>
    {
        #region Methods

        protected override void Invoke(object parameter)
        {
            if (parameter is SelectionChangedEventArgs)
            {
                ComboBox targetBox = (parameter as SelectionChangedEventArgs).OriginalSource as ComboBox;
                if (targetBox != null && this.Target.ColorModel != null)
                {
                    switch (targetBox.Name)
                    {
                        case "colorPaletteBox":
                            foreach (ChartSeries series in this.Target.Series)
                            {
                                series.Palette = (ChartColorPalette)Enum.Parse(typeof(ChartColorPalette), (targetBox.SelectedItem as ComboBoxItem).Content.ToString());
                            }
                            break;
                        case "comboExplodeIndex":
                            foreach (ChartSeries series in this.Target.Series)
                            {
                                ChartPieType.SetExplodedIndex(series, (int)targetBox.SelectedValue);
                            }
                            break;
                        case "comboExplodeRadius":
                            foreach (ChartSeries series in this.Target.Series)
                            {
                                ChartPieType.SetExplodeRadius(series, Convert.ToDouble(targetBox.SelectedValue.ToString()));
                            }
                            break;
                    }
                }
            }
        }

        #endregion
    }
}
