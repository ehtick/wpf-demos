﻿using System;
using System.Collections.ObjectModel;

namespace syncfusion.chartdemos.wpf
{
    class StepAreaChartViewModel : IDisposable
    {
        public ObservableCollection<StepAreaChartModel> CanadaData { get; set; }
        public ObservableCollection<StepAreaChartModel> MexicoData { get; set; }
        public StepAreaChartViewModel()
        {
            this.CanadaData = new ObservableCollection<StepAreaChartModel>();
            CanadaData.Add(new StepAreaChartModel() { Year = "2005", Value = 21 });
            CanadaData.Add(new StepAreaChartModel() { Year = "2006", Value = 21 });
            CanadaData.Add(new StepAreaChartModel() { Year = "2007", Value = 22 });
            CanadaData.Add(new StepAreaChartModel() { Year = "2008", Value = 29 });
            CanadaData.Add(new StepAreaChartModel() { Year = "2009", Value = 24 });
            CanadaData.Add(new StepAreaChartModel() { Year = "2010", Value = 25 });
            CanadaData.Add(new StepAreaChartModel() { Year = "2011", Value = 27 });
            CanadaData.Add(new StepAreaChartModel() { Year = "2012", Value = 26 });
            CanadaData.Add(new StepAreaChartModel() { Year = "2013", Value = 26 });
            CanadaData.Add(new StepAreaChartModel() { Year = "2014", Value = 29 });
            CanadaData.Add(new StepAreaChartModel() { Year = "2015", Value = 21 });

            this.MexicoData = new ObservableCollection<StepAreaChartModel>();
            MexicoData.Add(new StepAreaChartModel() { Year = "2005", Value = 15 });
            MexicoData.Add(new StepAreaChartModel() { Year = "2006", Value = 15 });
            MexicoData.Add(new StepAreaChartModel() { Year = "2007", Value = 16 });
            MexicoData.Add(new StepAreaChartModel() { Year = "2008", Value = 17 });
            MexicoData.Add(new StepAreaChartModel() { Year = "2009", Value = 13 });
            MexicoData.Add(new StepAreaChartModel() { Year = "2010", Value = 14 });
            MexicoData.Add(new StepAreaChartModel() { Year = "2011", Value = 16 });
            MexicoData.Add(new StepAreaChartModel() { Year = "2012", Value = 14 });
            MexicoData.Add(new StepAreaChartModel() { Year = "2013", Value = 13 });
            MexicoData.Add(new StepAreaChartModel() { Year = "2014", Value = 10 });
            MexicoData.Add(new StepAreaChartModel() { Year = "2015", Value = 6 });
        }

        public void Dispose()
        {
            if(CanadaData != null)
                CanadaData.Clear();

            if (MexicoData != null)
                MexicoData.Clear();
        }
    }
}
