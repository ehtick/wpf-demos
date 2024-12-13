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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syncfusion.chartdemos.wpf
{
    public class StackedBar100ViewModel
    {
        public StackedBar100ViewModel()
        {
            this.ElectricVehicleShare = new ObservableCollection<StackedBar100Model>();

            ElectricVehicleShare.Add(new StackedBar100Model() { Year = "2022 Q1",BYDAuto = 10, Tesla = 21,  VolkswagenGroup = 7, Others = 62});
            ElectricVehicleShare.Add(new StackedBar100Model() { Year = "2022 Q2",BYDAuto = 12, Tesla = 16,  VolkswagenGroup = 7, Others = 65});
            ElectricVehicleShare.Add(new StackedBar100Model() { Year = "2022 Q3",BYDAuto = 13, Tesla = 17,  VolkswagenGroup = 7, Others = 63});
            ElectricVehicleShare.Add(new StackedBar100Model() { Year = "2022 Q4",BYDAuto = 15, Tesla = 17,  VolkswagenGroup = 8, Others = 60 });
        }

        public ObservableCollection<StackedBar100Model> ElectricVehicleShare { get; set; }
    }
}






