#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using syncfusion.demoscommon.wpf;
using Syncfusion.UI.Xaml.ProgressBar;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace syncfusion.notificationdemos.wpf
{
    /// <summary>
    /// Represents the StepProgressBar customization class.
    /// </summary>
    public partial class StepProgressBarCustomization : DemoControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StepProgressBarCustomization"/> class.
        /// </summary>
        public StepProgressBarCustomization()
        {
            this.InitializeComponent();
            MarkerCustomization.MarkerClicked += MarkerCustomization_MarkerClicked;
            SecondaryContentAndContentCustomization.MarkerClicked += MarkerCustomization_MarkerClicked;
            ContentCustomization.MarkerClicked += MarkerCustomization_MarkerClicked;
        }

        private void MarkerCustomization_MarkerClicked(object sender, MarkerClickedEventArgs e)
        {
            ItemsControl itemsControl = ItemsControl.ItemsControlFromItemContainer(e.StepViewItem);
            int index = itemsControl.ItemContainerGenerator.IndexFromContainer(e.StepViewItem);
            (sender as SfStepProgressBar).SelectedIndex = index;
        }

        public StepProgressBarCustomization(string themename) : base(themename)
        {
            InitializeComponent();
            MarkerCustomization.MarkerClicked += MarkerCustomization_MarkerClicked;
            SecondaryContentAndContentCustomization.MarkerClicked += MarkerCustomization_MarkerClicked;
            ContentCustomization.MarkerClicked += MarkerCustomization_MarkerClicked;
        }
    }

    /// <summary>
    /// Method to select the custom data template for Marker.
    /// </summary>
    public class CustomShapeTemplate : DataTemplateSelector
    {
        /// <summary>
        /// Method to select the template based on status and index.
        /// </summary>
        /// <param name="item">stepview item.</param>
        /// <param name="container">step progress bar.</param>
        /// <returns>data template.</returns>
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            StepViewItem stepViewItem = item as StepViewItem;
            if (stepViewItem != null)
            {
                ItemsControl itemsControl = ItemsControl.ItemsControlFromItemContainer(stepViewItem);
                int index = itemsControl.ItemContainerGenerator.IndexFromContainer(stepViewItem);
                StepStatus stepStatus = stepViewItem.Status;
                stepViewItem.MarkerWidth = 50;
                stepViewItem.MarkerHeight = 50;
                if (stepStatus == StepStatus.Inactive && index == 0)
                {
                    return stepViewItem.FindResource("InactiveFirstStepTemplate") as DataTemplate;
                }
                else if (stepStatus == StepStatus.Indeterminate && index == 0)
                {
                    return stepViewItem.FindResource("IndeterminateFirstStepTemplate") as DataTemplate;
                }
                else if (stepStatus == StepStatus.Active && index == 0)
                {
                    return stepViewItem.FindResource("ActiveFirstStepTemplate") as DataTemplate;
                }
                else if (stepStatus == StepStatus.Inactive && index == 1)
                {
                    return stepViewItem.FindResource("InactiveSecondStepTemplate") as DataTemplate;
                }
                else if (stepStatus == StepStatus.Indeterminate && index == 1)
                {
                    return stepViewItem.FindResource("IndeterminateSecondStepTemplate") as DataTemplate;
                }
                if (stepStatus == StepStatus.Active && index == 1)
                {
                    return stepViewItem.FindResource("ActiveSecondStepTemplate") as DataTemplate;
                }
                else if (stepStatus == StepStatus.Inactive && index == 2)
                {
                    return stepViewItem.FindResource("InactiveThirdStepTemplate") as DataTemplate;
                }
                else if (stepStatus == StepStatus.Indeterminate && index == 2)
                {
                    return stepViewItem.FindResource("IndeterminateThirdStepTemplate") as DataTemplate;
                }
                else if (stepStatus == StepStatus.Active && index == 2)
                {
                    return stepViewItem.FindResource("ActiveThirdStepTemplate") as DataTemplate;
                }
            }
            return null;
        }
    }

    /// <summary>
    /// Method to select the rectangle data template for Marker.
    /// </summary>
    public class CustomRectangleTemplate : DataTemplateSelector
    {
        /// <summary>
        /// Method to select the template based on status and index.
        /// </summary>
        /// <param name="item">stepview item.</param>
        /// <param name="container">step progress bar.</param>
        /// <returns>data template.</returns>
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            StepViewItem stepViewItem = item as StepViewItem;
            stepViewItem.MarkerWidth = 40;
            stepViewItem.MarkerHeight = 40;
            if (stepViewItem != null)
            {
                if (stepViewItem.Status == StepStatus.Active)
                {
                    return stepViewItem.FindResource("CompletedTemplate") as DataTemplate;
                }
                else if (stepViewItem.Status == StepStatus.Indeterminate)
                {
                    return stepViewItem.FindResource("InProgressTemplate") as DataTemplate;
                }
                else
                {
                    return stepViewItem.FindResource("NotStartedTemplate") as DataTemplate;
                }
            }

            return null;
        }
    }

    /// <summary>
    /// Method to select the custom data template for marker.
    /// </summary>
    public class CustomMarkerTemplateSelectorTemplate : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            StepViewItem stepViewItem = item as StepViewItem;
            stepViewItem.MarkerWidth = 30;
            stepViewItem.MarkerHeight = 30;
            if (stepViewItem != null)
            {
                StepStatus stepperState = stepViewItem.Status;
                if (stepperState == StepStatus.Indeterminate)
                {
                    return stepViewItem.FindResource("IndeterminateCircleTemplate") as DataTemplate;
                }
                else if (stepperState == StepStatus.Active)
                {
                    return stepViewItem.FindResource("ActiveCircleTemplate") as DataTemplate;
                }
                else
                {
                    return stepViewItem.FindResource("InactiveCircleTemplate") as DataTemplate;
                }
            }
            return null;
        }
    }

   
}
