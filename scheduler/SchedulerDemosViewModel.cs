#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using syncfusion.demoscommon.wpf;

namespace syncfusion.schedulerdemos.wpf
{
    public class SchedulerDemosViewModel : DemoBrowserViewModel
    {
        public override List<ProductDemo> GetDemosDetails()
        {
            var productdemos = new List<ProductDemo>();
            productdemos.Add(new SchedulerProductDemos());
            return productdemos;
        }
    }
    public class SchedulerProductDemos : ProductDemo
    {
        public SchedulerProductDemos()
        {
            this.Product = "Scheduler";
            this.ProductCategory = "CALENDAR";
            this.ListViewImagePathData = new System.Windows.Shapes.Path()
            {
                Data = Geometry.Parse("M2.5 13H6.56L6.29 14H2.5C1.12 14 0 12.88 0 11.5V4.5V2.5C0 1.12 1.12 0 2.5 0H11.5C12.88 0 14 1.12 14 2.5V4.5V5.95999C13.86 5.91999 13.72 5.89999 13.58 5.89999C13.38 5.89999 13.18 5.93999 13 6.00999V5H1V11.5C1 12.33 1.67 13 2.5 13ZM1 4H13V2.5C13 1.67 12.33 1 11.5 1H2.5C1.67 1 1 1.67 1 2.5V4ZM4.21094 6.19922C4.76322 6.19922 5.21094 6.64693 5.21094 7.19922C5.21094 7.7515 4.76322 8.19922 4.21094 8.19922C3.65865 8.19922 3.21094 7.7515 3.21094 7.19922C3.21094 6.64693 3.65865 6.19922 4.21094 6.19922ZM5.21094 11.1992C5.21094 10.6469 4.76322 10.1992 4.21094 10.1992C3.65865 10.1992 3.21094 10.6469 3.21094 11.1992C3.21094 11.7515 3.65865 12.1992 4.21094 12.1992C4.76322 12.1992 5.21094 11.7515 5.21094 11.1992ZM11.4199 14.0002H11.4999C12.8799 14.0002 13.9999 12.8802 13.9999 11.5002V11.4102L11.4199 14.0002ZM15.4207 7.97922L14.2807 6.83922C14.1907 6.74922 14.0707 6.69922 13.9407 6.69922C13.8107 6.69922 13.6907 6.74922 13.6007 6.83922L7.9707 12.4692L9.8007 14.2992L15.4307 8.66922C15.5207 8.57922 15.5707 8.45922 15.5707 8.32922C15.5707 8.19922 15.5207 8.07921 15.4307 7.98921L15.4207 7.97922ZM7.25055 13.1792L6.56055 15.6992L9.08055 15.0092L9.31055 14.7792L7.48055 12.9492L7.25055 13.1792Z"),
                Width = 16,
                Height = 16,
            };

            this.IsHighlighted = true;
            this.Demos = new List<DemoInfo>();
            this.HeaderImageSource = new BitmapImage(new Uri(@"/syncfusion.demoscommon.wpf;component/Assets/ProductCategoryImages/Calendar.png", UriKind.RelativeOrAbsolute));
            this.ControlDescription = "The Scheduler control is used for creating and managing appointments with an intuitive user interface. It has many customizable features.";
            this.GalleryViewImageSource = new BitmapImage(new Uri(@"/syncfusion.demoscommon.wpf;component/Assets/GalleryViewImages/Scheduler.png", UriKind.RelativeOrAbsolute));

            DemoInfo GettingStartedDemo = new DemoInfo()
            {
                SampleName = "Getting Started",
                GroupName = "GETTING STARTED",
                Description = "This sample showcases the scheduler views such as day, week, workweek and month views with scheduler appointments added. It also showcases the date navigation restriction within minimum and maximum scheduler date range, blackout dates restriction in month view and to navigate quickly to the day view by tapping on the month cell and view header of the scheduler views.",
                DemoViewType = typeof(GettingStartedDemo),

            };

            List<Documentation> GettingStartedHelpDocuments = new List<Documentation>()
            {
                new Documentation(){ Content = "Scheduler - Getting Started", Uri = new Uri("https://help.syncfusion.com/wpf/scheduler/getting-started")}
            };

            GettingStartedDemo.Documentations = GettingStartedHelpDocuments;
            this.Demos.Add(GettingStartedDemo);
            this.Demos.Add(new DemoInfo() { SampleName = "Data Binding", Description = "This sample showcases to binding any business event object to the scheduler items source using the property mapping concept.", GroupName = "GETTING STARTED", DemoViewType = typeof(DataBindingDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Timeline views", Description = "This sample showcases the scheduler timeline day, timeline week, timeline work week and timeline month views. It also showcases the capabilities of creating recurring appointments on daily, weekly, monthly, and yearly intervals in timeline day, timeline week, timeline work week and timeline month views, creating the recurrence appointment with exception date and changed occurrence of recurring series appointments and the capabilities of highlighting specific regions in timeslot cells and restricting user interactions such as selection, appointment creations.", GroupName = "GETTING STARTED", DemoViewType = typeof(TimelineViewsDemo) });

            this.Demos.Add(new DemoInfo() { SampleName = "Appointment", Description = "This sample showcases the customization capabilities of the scheduler appointment control.", GroupName = "CUSTOMIZATION", DemoViewType = typeof(AppointmentCustomizationDemo), ThemeMode = ThemeMode.Default });
            this.Demos.Add(new DemoInfo() { SampleName = "Time Slot", Description = "This sample showcases the capabilities to navigate to specific dates in scheduler views, show or hide header view, time ruler label and 24 hours time ruler format in the scheduler.", GroupName = "CUSTOMIZATION", DemoViewType = typeof(TimeSlotCustomizationDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Fare Calendar ", Description = "This sample showcases the customization capabilities of a scheduler month cell.", GroupName = "CUSTOMIZATION", DemoViewType = typeof(MonthCellCustomizationDemo), ThemeMode = ThemeMode.Default });
            this.Demos.Add(new DemoInfo() { SampleName = "Special Time Region", Description = "This sample showcases the capabilities of highlighting specific regions in timeslot cells and restricting user interactions such as selection, appointment creation and customize the appearance of highlighted timeslot cells.", GroupName = "CUSTOMIZATION", DemoViewType = typeof(SpecialTimeRegionCustomizationDemo), ThemeMode = ThemeMode.Default });

            this.Demos.Add(new DemoInfo() { SampleName = "Recurring Appointments", Description = "This sample showcases the capabilities of creating recurring appointments on daily, weekly, monthly, and yearly intervals in day, week, workweek and month views.", GroupName = "APPOINTMENTS", DemoViewType = typeof(RecurringAppointmentsDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Recurring Appointment with Exception", Description = "This sample showcases the capabilities of creating the recurrence appointment with exception date and changed occurrence of recurring series appointments.", GroupName = "APPOINTMENTS", DemoViewType = typeof(RecurrencewithExceptionDemo) });

            this.Demos.Add(new DemoInfo() { SampleName = "Calendar Identifier", Description = "This example shows how to use the scheduler to set several calendar types such as Gregorian, Korean, Hebrew, and so on.", GroupName = "CALENDAR TYPES", DemoViewType = typeof(CalendarIdentifierDemo)});

            this.Demos.Add(new DemoInfo() { SampleName = "Horizontal Grouping", Description = "This sample showcases the capabilities to display or group appointments based on the resources in day, week and workweek views.", GroupName = "RESOURCES", DemoViewType = typeof(HorizontalResourceGroupingDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Date-wise Grouping", Description = "This sample showcases the capabilities to display or group appointments based on the dates in day, week and workweek views.", GroupName = "RESOURCES", DemoViewType = typeof(DateWiseResourceGroupingDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Timeline Grouping", Description = "This sample showcases the capabilities to display or group appointments based on the resources in timeline day, timeline week, timeline workweek and timeline month views.", GroupName = "RESOURCES", DemoViewType = typeof(TimelineResourceGroupingDemo)});

            this.Demos.Add(new DemoInfo() { SampleName = "Load on demand", Description = "This sample showcases the appointment on demand loading capability of the scheduler with business event object binding.", GroupName = "LOAD ON DEMAND", DemoViewType = typeof(LoadOnDemandDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Reminder", Description = "This sample showcases the scheduler appointment reminder’s feature with business event object binding.", GroupName = "REMINDER", DemoViewType = typeof(ReminderDemo) });

            this.Demos.Add(new DemoInfo() { SampleName = "Context Menu", Description = "This sample showcases the context menu to add, edit and delete the appointments by using the RoutedUICommands support for the time slots, month cells and scheduler appointments.", GroupName = "INTERACTIVE FEATURES", DemoViewType = typeof(ContextMenuDemo), ThemeMode = ThemeMode.Default });
            this.Demos.Add(new DemoInfo() { SampleName = "Drag and Drop", Description = "The scheduler allows drag and drop the appointments in all views and this sample showcases the drag and drop behavior between ListView and Scheduler.", GroupName = "INTERACTIVE FEATURES", DemoViewType = typeof(DragandDropDemo) });            
        }
    }
}
