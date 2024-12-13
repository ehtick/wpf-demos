#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

namespace syncfusion.pivotgriddemos.wpf
{
    using Syncfusion.Windows.Controls.PivotGrid;
    using Microsoft.Xaml.Behaviors;
    using Syncfusion.Windows.Controls.Grid;
    using Syncfusion.UI.Xaml.Grid;

    public class HyperLinkAction : TargetedTriggerAction<SfDataGrid>
    {
        protected override void Invoke(object parameter)
        {
            if (parameter is HyperlinkCellClickEventArgs)
            {
                HyperlinkCellClickEventArgs eventArgs = parameter as HyperlinkCellClickEventArgs;
                this.Target.ItemsSource = (this.AssociatedObject as PivotGridControl).PivotEngine.GetRawItemsFor(eventArgs.RowColumnIndex.RowIndex, eventArgs.RowColumnIndex.ColumnIndex);
            }
        }
    }
}