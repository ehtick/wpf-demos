#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

namespace syncfusion.olapchartdemos.wpf
{
    using System;
    using Syncfusion.Windows.Chart;
    using Syncfusion.Windows.Shared;
    using Syncfusion.Olap.Manager;
    using System.Windows;
    using Syncfusion.Olap.Reports;

    class ColumnChartViewModel : NotificationObject, IDisposable
    {
        #region Members

        /// <summary>
        /// Shared connection string.
        /// </summary>
        public static string ConnectionString;
        private OlapDataManager olapDataManager;
        private ChartTypes olapChartType = ChartTypes.Column;
        private Visibility showLegend = Visibility.Visible;
        private DelegateCommand<object> legendDelegateCommand;
        private DelegateCommand<object> selectionCommand;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnChartViewModel"/> class.
        /// </summary>
        public ColumnChartViewModel()
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
        /// Gets the selection command.
        /// </summary>
        /// <value>The selection command.</value>
        public DelegateCommand<object> SelectionCommand
        {
            get
            {
                return selectionCommand ?? new DelegateCommand<object>(ToggleSelection);
            }
            set { selectionCommand = value; }
        }


        /// <summary>
        /// Gets or sets the type of the OLAP chart.
        /// </summary>
        /// <value>The type of the OLAP chart.</value>
        public ChartTypes OlapChartType
        {
            get
            {
                return olapChartType;
            }
            set
            {
                olapChartType = value;
                RaisePropertyChanged("OlapChartType");
            }
        }


        /// <summary>
        /// Gets or sets the legend visibility.
        /// </summary>
        /// <value>The legend visibility.</value>
        public Visibility ShowLegend
        {
            get { return showLegend; }
            set { showLegend = value; RaisePropertyChanged("ShowLegend"); }
        }

        /// <summary>
        /// Gets or sets the delegate command to show legend.
        /// </summary>
        /// <value>The delegate command to show legend.</value>
        public DelegateCommand<object> LegendDelegateCommand
        {
            get
            {
                return legendDelegateCommand ?? new DelegateCommand<object>(LegendOption);
            }
            set
            {
                legendDelegateCommand = value;
            }
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
            if (disposing && this.olapDataManager != null)
                this.olapDataManager.Dispose();
        }

        /// <summary>
        /// Toggles the chart type.
        /// </summary>
        /// <param name="param">The parameter.</param>
        private void ToggleSelection(object param)
        {
            string m_chartType = param.ToString();
            if (m_chartType == "Column")
                this.OlapChartType = ChartTypes.Column;
            else if (m_chartType == "Stacking Column")
                this.OlapChartType = ChartTypes.StackingColumn;
            else if (m_chartType == "Stacking Column 100")
                this.OlapChartType = ChartTypes.StackingColumn100;
        }

        private OlapReport SimpleDimensions()
        {
            OlapReport olapReport = new OlapReport();
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
        /// Shows the legend of the control.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        private void LegendOption(object parameter)
        {
            this.ShowLegend = parameter.ToString() == "True" ? Visibility.Visible : Visibility.Collapsed;
        }

        #endregion
    }
}
