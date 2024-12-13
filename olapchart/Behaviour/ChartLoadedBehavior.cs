#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

namespace syncfusion.olapchartdemos.wpf
{
    using Syncfusion.Windows.Chart.Olap;
    using Syncfusion.Windows.Chart;
    using System.Windows;
    using Microsoft.Xaml.Behaviors;
    using System;

    public class ChartLoadedBehavior : Behavior<OlapChart>
    {
        private ResourceDictionary CommonResourceDictionary { get; set; }

        protected override void OnAttached()
        {
            base.OnAttached();
            this.AssociatedObject.Loaded += new System.Windows.RoutedEventHandler(AssociatedObject_Loaded);
        }
        protected override void OnDetaching()
        {
            this.AssociatedObject.Loaded -= new System.Windows.RoutedEventHandler(AssociatedObject_Loaded);
            base.OnDetaching();
        }
        void AssociatedObject_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            CommonResourceDictionary = new ResourceDictionary() { Source = new Uri("/syncfusion.olapchartdemos.wpf;component/Resources/olapchart/OlapChartIcon.xaml", UriKind.RelativeOrAbsolute) };

            foreach (ChartSeries series in this.AssociatedObject.Series)
            {
                series.AdornmentsInfo = new ChartAdornmentInfo
                {
                    Visible = true,
                    HorizontalAlignment = System.Windows.HorizontalAlignment.Left,
                    VerticalAlignment = System.Windows.VerticalAlignment.Center,
                    LabelTemplate = CommonResourceDictionary["DataLabelTemplate"] as DataTemplate
                };
            }
        }


    }
}
