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
    using Syncfusion.Olap.Manager;
    using Syncfusion.Olap.Reports;
    using Syncfusion.Windows.Shared;

    /// <summary>
    /// ViewModel Class
    /// </summary>
    public class ExpandersVisibilityViewModel : NotificationObject, IDisposable
    {
        #region Members

        /// <summary>
        /// Shared connection string.
        /// </summary>
        public static string ConnectionString;
        private OlapDataManager olapDataManager;
        private DelegateCommand<object> expandDelegateCommand;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpandersVisibilityViewModel"/> class.
        /// </summary>
        public ExpandersVisibilityViewModel()
        {
            ConnectionString = OlapChartModel.Initialize(System.IO.Path.GetFullPath(@"Assets\Config\OLAPSample.config"));
            olapDataManager = new OlapDataManager(ConnectionString);
            olapDataManager.SetCurrentReport(SimpleDimensions());
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


        /// <summary>
        /// Gets or sets the delegate command to show expander.
        /// </summary>
        /// <value>The delegate command to show expander.</value>
        public DelegateCommand<object> ExpandDelegateCommand
        {
            get
            {
                return expandDelegateCommand ?? new DelegateCommand<object>(ExpandOption);
            }
            set
            {
                expandDelegateCommand = value;
            }
        }

        #endregion

        #region Helper Methods

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private OlapReport SimpleDimensions()
        {
            OlapReport olapReport = new OlapReport();
            //Selecting the cube to analyse
            olapReport.CurrentCubeName = "Adventure Works";
            DimensionElement dimensionElementColumn = new DimensionElement();
            //Specifying the Column Name for the Dimension and measure elements
            dimensionElementColumn.Name = "Customer";
            dimensionElementColumn.AddLevel("Customer Geography", "Country");
            MeasureElements measureElementColumn = new MeasureElements();
            measureElementColumn.Elements.Add(new MeasureElement { Name = "Internet Sales Amount" });

            //Specifying the Row Name for the Dimension element
            DimensionElement dimensionElementRow = new DimensionElement();
            dimensionElementRow.Name = "Date";
            dimensionElementRow.AddLevel("Fiscal", "Fiscal Year");

            //Adding Column Members
            olapReport.CategoricalElements.Add(dimensionElementColumn);
            //Adding Measure Element
            olapReport.CategoricalElements.Add(measureElementColumn);
            //Adding Row Members
            olapReport.SeriesElements.Add(dimensionElementRow);
            return olapReport;
        }

        /// <summary>
        /// Shows the expander of the control.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        private void ExpandOption(object parameter)
        {
            this.DataManager.CurrentReport.ShowExpanders = parameter.ToString() == "True";
            this.DataManager.NotifyElementModified();
        }

        private void Dispose(bool disposing)
        {
            if (disposing && this.olapDataManager != null)
                this.olapDataManager.Dispose();
        }

        #endregion
    }
}
