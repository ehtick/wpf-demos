#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Interactivity;
using Syncfusion.Windows.Tools.Controls;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows;
using Syncfusion.Windows.Shared;

namespace HierarchyNavigator_2008
{
    /// <summary>
    /// Represents the action for selection changes.
    /// </summary>
    public class SelectionChangedAction : TargetedTriggerAction<ComboBox>
    {
#if Framework3_5       
        public FrameworkElement TargetObject
        {
            get { return (FrameworkElement)GetValue(TargetObjectProperty); }
            set { SetValue(TargetObjectProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Target.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TargetObjectProperty =
            DependencyProperty.Register("TargetObject", typeof(FrameworkElement), typeof(SelectionChangedAction), new UIPropertyMetadata(null));
#endif

		/// <summary>
        /// Method which invokes the selection changed action.
        /// </summary>
        /// <param name="parameter">Parameter invokes the routed event</param>
        protected override void Invoke(object parameter)
        {
            RoutedEventArgs routedEvent = parameter as RoutedEventArgs;
            ((HierarchyNavigator)TargetObject).MaxDrillDownLevel = Convert.ToInt16(((routedEvent.OriginalSource as ComboBox).SelectedValue as ComboBoxItem).Content.ToString());
        }
    }
}