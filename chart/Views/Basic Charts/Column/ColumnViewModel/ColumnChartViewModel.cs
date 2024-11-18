#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace syncfusion.chartdemos.wpf
{
    public class ColumnChartViewModel
    {
        public ObservableCollection<ColumnChartModel> DefaultColumnData { get; }
        public ObservableCollection<ColumnChartModel> RoundedColumnData { get; }
        public ObservableCollection<ColumnChartModel> ColumnWidthData { get; }
      
        public ColumnChartViewModel()
        {
            //Default column
            this.DefaultColumnData = new ObservableCollection<ColumnChartModel>();
            DefaultColumnData.Add(new ColumnChartModel() { Name = "China", Value = 0.541 });
            DefaultColumnData.Add(new ColumnChartModel() { Name = "Egypt", Value = 0.818 });
            DefaultColumnData.Add(new ColumnChartModel() { Name = "Bolivia", Value = 1.51 });
            DefaultColumnData.Add(new ColumnChartModel() { Name = "Mexico", Value = 1.302 });
            DefaultColumnData.Add(new ColumnChartModel() { Name = "Brazil", Value = 2.017 });

            //Rounded column
            this.RoundedColumnData = new ObservableCollection<ColumnChartModel>();
            RoundedColumnData.Add(new ColumnChartModel() { Name = "New York", Value = 8683 });
            RoundedColumnData.Add(new ColumnChartModel() { Name = "Tokyo", Value = 6993 });
            RoundedColumnData.Add(new ColumnChartModel() { Name = "Chicago", Value = 5498 });
            RoundedColumnData.Add(new ColumnChartModel() { Name = "Atlanta", Value = 5083 });
            RoundedColumnData.Add(new ColumnChartModel() { Name = "Boston", Value = 4497 });

            //Width and spacing
            this.ColumnWidthData = new ObservableCollection<ColumnChartModel>();
            ColumnWidthData.Add(new ColumnChartModel() { Name = "Norway", Gold = 16, Silver = 8, Bronze = 13 });
            ColumnWidthData.Add(new ColumnChartModel() { Name = "Russia", Gold = 6, Silver = 12, Bronze = 14 });
            ColumnWidthData.Add(new ColumnChartModel() { Name = "Germany", Gold = 12, Silver = 10, Bronze = 5 });
            ColumnWidthData.Add(new ColumnChartModel() { Name = "Canada", Gold = 4, Silver = 8, Bronze = 14 });
        }
    }
}
