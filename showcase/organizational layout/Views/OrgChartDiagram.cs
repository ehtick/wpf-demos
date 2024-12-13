#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.UI.Xaml.Diagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syncfusion.organizationallayout.wpf
{
    //Derived Diagram to Customize the Selector
   public class OrgChartDiagram:SfDiagram
    {
       public Syncfusion.UI.Xaml.Diagram.Selector SFSelector = new Syncfusion.UI.Xaml.Diagram.Selector();
       protected override Syncfusion.UI.Xaml.Diagram.Selector GetSelectorForItemOverride(object item)
       {
           return SFSelector;
       }
    }
}
