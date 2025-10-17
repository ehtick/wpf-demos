﻿using System;
using System.Collections.ObjectModel;

namespace syncfusion.chartdemos.wpf
{
    public class StackedGroup100ViewModel : IDisposable
    {
        public ObservableCollection<StackedGroup100Model> USElectricityData { get; set; }

        public ObservableCollection<StackedGroup100Model> UKElectricityData { get; set; }
        public StackedGroup100ViewModel()
        {
            USElectricityData = new ObservableCollection<StackedGroup100Model>()
              {
                new StackedGroup100Model("2017",62.68,19.86,17.45),
                new StackedGroup100Model("2018",63.34,19.21,17.45),
                new StackedGroup100Model("2019",62.24,19.46,18.29),
                new StackedGroup100Model("2020",60.15,19.54,20.32),
                new StackedGroup100Model("2021",60.49,18.77,20.74),
                };

            UKElectricityData = new ObservableCollection<StackedGroup100Model>()
              {
               new StackedGroup100Model("2017",49.51,20.99,29.50),
               new StackedGroup100Model("2018",47.02,19.69,33.29),
               new StackedGroup100Model("2019",45.08,17.47,37.46),
               new StackedGroup100Model("2020",40.60,16.54,42.86),
               new StackedGroup100Model("2021",44.95,15.26,39.78),
              };
        }

        public void Dispose()
        {
            if(USElectricityData != null)
                USElectricityData.Clear();

            if(UKElectricityData != null)
                UKElectricityData.Clear();
        }
    }
} 

