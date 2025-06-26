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
    using Syncfusion.Windows.Shared;
    using Syncfusion.Olap.Manager;
    using Syncfusion.Olap.Reports;

    class ProductTrendAnalysisViewModel : NotificationObject, IDisposable
    {
        #region Members

        /// <summary>
        /// Shared connection string.
        /// </summary>
        public static string ConnectionString;
        private OlapDataManager olapDataManager;
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductTrendAnalysisViewModel"/> class.
        /// </summary>
        public ProductTrendAnalysisViewModel()
        {
            ConnectionString = OlapChartModel.Initialize(System.IO.Path.GetFullPath(@"Assets\Config\OLAPSample.config"));
            olapDataManager = new OlapDataManager(ConnectionString);
            olapDataManager.SetCurrentReport(OlapReport());
        }

        #endregion

        #region Properties


        /// <summary>
        /// Gets or sets the grid data manager.
        /// </summary>
        /// <value>The grid data manager.</value>
        public OlapDataManager DataManager
        {
            get { return olapDataManager; }
            set { olapDataManager = value; }
        }

        #endregion

        #region Helper Method

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (this.olapDataManager != null)
                this.olapDataManager.Dispose();
        }

        private OlapReport OlapReport()
        {
            OlapReport olapReport = new OlapReport();
            olapReport.Name = "LineChart";
            olapReport.CurrentCubeName = "Adventure Works";

            DimensionElement dimensionColumn = new DimensionElement();
            dimensionColumn.Name = "Product";
            dimensionColumn.AddLevel("Product Categories", "Category");
            dimensionColumn.Hierarchy.LevelElements["Category"].IncludeAvailableMembers = true;
            dimensionColumn.Hierarchy.LevelElements["Category"].Add("Accessories");
            dimensionColumn.Hierarchy.LevelElements["Category"].Add("Clothing");

            MeasureElements meansureElements = new MeasureElements();
            meansureElements.Elements.Add(new MeasureElement() { Name = "Internet Gross Profit" });

            DimensionElement dimensionRow = new DimensionElement();
            dimensionRow.Name = "Date";
            dimensionRow.AddLevel("Week Of Year", "Week Of Year");

            SubsetElement subSetElementRow = new SubsetElement(10);
            subSetElementRow.Name = "Top 10 Elements";

            olapReport.CategoricalElements.Add(dimensionColumn);
            olapReport.CategoricalElements.Add(meansureElements);
            olapReport.SeriesElements.Add(dimensionRow);
            olapReport.SeriesElements.SubSetElement = subSetElementRow;

            return olapReport;
        }

        #endregion
    }
}
