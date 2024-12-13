#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.UI.Xaml.Diagram;
using Syncfusion.UI.Xaml.Diagram.Stencil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace syncfusion.diagramdemo.wpf.ViewModel
{
    public class LocalizationRibbonViewModel : DiagramViewModel
    {
        //To Represent ResourceManager
        System.Resources.ResourceManager manager;
        public LocalizationRibbonViewModel()
        {
            ////Initialize Assembly
            Assembly assembly = this.GetType().Assembly;
            manager = new System.Resources.ResourceManager("syncfusion.diagramdemos.wpf.Resources.Syncfusion.SfDiagram.Wpf", assembly);

            Symbolfilters = new SymbolFilters();
            SymbolFilterProvider all = new SymbolFilterProvider { Content = manager.GetString("All"), SymbolFilter = Filter };
            SymbolFilterProvider basicshapes = new SymbolFilterProvider { Content = manager.GetString("BasicShapes"), SymbolFilter = Filter };
            SymbolFilterProvider flowshapes = new SymbolFilterProvider { Content = manager.GetString("FlowShapes"), SymbolFilter = Filter };           
            SymbolFilterProvider arrowshapes = new SymbolFilterProvider { Content = manager.GetString("ArrowShapes"), SymbolFilter = Filter };

            this.Symbolfilters.Add(all);
            this.Symbolfilters.Add(basicshapes);
            this.Symbolfilters.Add(flowshapes);            
            this.Symbolfilters.Add(arrowshapes);
            this.Selectedfilter = Symbolfilters[0];
        }

        // Define filtering of Symbols
        private bool Filter(SymbolFilterProvider sender, object symbol)
        {
            if (sender.Content.ToString() == "Toute")
            {
                return true;
            }
            if (sender.Content.ToString() == (symbol as NodeViewModel).Key.ToString())
            {
                return true;
            }
            if (sender.Content.ToString() == (symbol as NodeViewModel).Key.ToString())
            {
                return true;
            }
            if (sender.Content.ToString() == (symbol as NodeViewModel).Key.ToString())
            {
                return true;
            }
            return false;
        }

        private SymbolFilters symbolfilters;

        public SymbolFilters Symbolfilters
        {
            get
            {
                return symbolfilters;
            }
            set
            {
                symbolfilters = value;
                OnPropertyChanged("Symbolfilters");
            }
        }

        private SymbolFilterProvider selectedfilter;

        public SymbolFilterProvider Selectedfilter
        {
            get
            {
                return selectedfilter;
            }
            set
            {
                selectedfilter = value;
                OnPropertyChanged("Selectedfilter");
            }
        }
    }
}
