#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.Practices.Composite.UnityExtensions;
using System.Windows;
using Microsoft.Practices.Composite.Modularity;
using Microsoft.Practices.Composite.Presentation.Regions;
using Syncfusion.Windows.Tools.Controls;

namespace syncfusion.portfolioanalyzerdemo.wpf
{
    public class Bootstrapper : UnityBootstrapper
    {
        /// <summary>
        /// Creates the shell.
        /// </summary>
        /// <returns></returns>
        protected override DependencyObject CreateShell()
        {
            Shell shell = Container.Resolve<Shell>();
            shell.Show();
            return shell;
        }

        /// <summary>
        /// creates and populates the module catalog
        /// </summary>
        /// <returns>The populated catalog</returns>
        protected override IModuleCatalog GetModuleCatalog()
        {
            ModuleCatalog catalog = new ModuleCatalog();
            catalog.AddModule(typeof(AccountsModule))
                   .AddModule(typeof(StockListModule))
                   .AddModule(typeof(HistoryChartModule))
                   .AddModule(typeof(PortfolioGridModule), InitializationMode.OnDemand)
                   .AddModule(typeof(CountrySectorChartModule), InitializationMode.OnDemand)
                   .AddModule(typeof(RibbonModule));
            return catalog;
        }


        /// <summary>
        /// Registering Custom Region Adapters.
        /// </summary>
        /// <returns>The region mappings</returns>
        protected override RegionAdapterMappings ConfigureRegionAdapterMappings()
        {
            RegionAdapterMappings mappings = base.ConfigureRegionAdapterMappings();

            if (mappings != null)
            {
                mappings.RegisterMapping(typeof(Ribbon), this.Container.Resolve<RibbonControlRegionAdapter>());
                mappings.RegisterMapping(typeof(DockingManager), this.Container.Resolve<DockingRegionAdapter>());
                mappings.RegisterMapping(typeof(RibbonTab), this.Container.Resolve<RibbonTabRegionAdapter>());
                mappings.RegisterMapping(typeof(ApplicationMenu), this.Container.Resolve<ApplicationMenuRegionAdapter>());
            }

            return mappings;
        }
    }
}
