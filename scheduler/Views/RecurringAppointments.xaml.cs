#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using syncfusion.demoscommon.wpf;
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

namespace syncfusion.schedulerdemos.wpf
{
    /// <summary>
    /// Interaction logic for RecurringAppointments.xaml
    /// </summary>
    public partial class RecurringAppointmentsDemo : DemoControl
    {
        public RecurringAppointmentsDemo()
        {
            InitializeComponent();
        }
        public RecurringAppointmentsDemo(string themename) : base(themename)
        {
            InitializeComponent();
        }
        protected override void Dispose(bool disposing)
        {
            if (this.Schedule != null)
            {
                this.Schedule.Dispose();
                this.Schedule = null;
            }
            base.Dispose(disposing);
        } 
    }
}
