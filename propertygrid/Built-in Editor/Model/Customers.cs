#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.ComponentModel;

namespace syncfusion.propertygriddemos.wpf
{
    public class Customers
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
       
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
