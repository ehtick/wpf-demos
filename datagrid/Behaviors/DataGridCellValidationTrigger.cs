#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.Xaml.Behaviors;
using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syncfusion.datagriddemos.wpf
{
    public class DataGridCellValidationTrigger : TargetedTriggerAction<SfDataGrid>
    {  
        protected override void Invoke(object parameter)
        {
             
            if(parameter is RowValidatingEventArgs)
            {
                RowValidatingEventArgs args = parameter as RowValidatingEventArgs;
                var data = args.RowData as OrderInfo;
                decimal columnData = 0;
                decimal compareData = 0;
                double total = data.Freight + data.Expense;
                decimal.TryParse(total.ToString(), out columnData);
                decimal.TryParse("3000", out compareData);

                NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
                {
                    CurrencyDecimalDigits = NumberFormatInfo.CurrentInfo.CurrencyDecimalDigits,
                    CurrencyDecimalSeparator = NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator,
                    CurrencyGroupSeparator = NumberFormatInfo.CurrentInfo.CurrencyGroupSeparator,
                    CurrencyNegativePattern = NumberFormatInfo.CurrentInfo.CurrencyNegativePattern,
                    CurrencyPositivePattern = NumberFormatInfo.CurrentInfo.CurrencyPositivePattern,
                    CurrencySymbol = NumberFormatInfo.CurrentInfo.CurrencySymbol,
                };
                if (Convert.ToDouble(columnData) < Convert.ToDouble(compareData))
                {
                    args.ErrorMessages.Add("Expense", "Sum of Expense and Freight should be a minimum of 3000 to be eligible for Discount.");
                    args.IsValid = false;
                }
            }
            else
            {
                CurrentCellValidatingEventArgs args = parameter as CurrentCellValidatingEventArgs;
                if (args.Column.MappingName == "Discount" && Convert.ToDouble(args.NewValue) > 40)
                {
                    args.ErrorMessage = "Discount should not exceed 40 percent.";
                    args.IsValid = false;
                }
            }
        }
    }
}
