#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Linq;
using Microsoft.Practices.Composite.Regions;
using Microsoft.Practices.Composite.Presentation.Regions;
using Syncfusion.Windows.Tools.Controls;
using System.Windows;

namespace syncfusion.portfolioanalyzerdemo.wpf
{
    public class TabControlExtRegionAdapter : RegionAdapterBase<TabControlExt>
    {
        public TabControlExtRegionAdapter(IRegionBehaviorFactory regionBehaviorFactory)
            :base(regionBehaviorFactory)
        {
        }

        protected override void Adapt(IRegion region, TabControlExt regionTarget)
        {
            region.Views.CollectionChanged += delegate
            {
                foreach (var tab in region.Views.Cast<FrameworkElement>())
                {
                    if (!regionTarget.Items.Contains(tab))
                    {
                        regionTarget.Items.Add(tab);
                    }
                }
            };
        }

        protected override IRegion CreateRegion()
        {
            return new Region();
        }
    }
}
