#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace syncfusion.weatheranalysis.wpf
{
    public class HistoricalWeatherInfoModel
    {
        public string Month { get; set; }

        public int Rainfall { get; set; }

        public int SnowDays { get; set; }

        public float AvgLowTemperature { get; set; }

        public float AvgHighTemperature { get; set; }
    }
}
