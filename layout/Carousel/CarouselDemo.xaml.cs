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

namespace syncfusion.layoutdemos.wpf
{
    /// <summary>
    /// Interaction logic for Carousel.xaml
    /// </summary>
    public partial class CarouselDemo : DemoControl
    {
        public CarouselDemo()
        {
            InitializeComponent();
        }
        public CarouselDemo(string themename):base(themename)
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            //Release all managed resources

            if(RotationSpeedTypes!=null)
            {
                RotationSpeedTypes.Dispose();
                RotationSpeedTypes = null;
            }
            if (this.carousel != null)
            {
                this.carousel.Dispose();
                this.carousel = null;
            }
            var viewModel = this.DataContext as CarouselViewModel;
            if (viewModel != null)
            {
                viewModel.ItemsCollection = null;
            }
            this.DataContext = null;
            if (this.optionsGrid != null)
            {
                this.optionsGrid.Children.Clear();
                this.optionsGrid = null;
            }
            if (this.carouselGrid != null)
            {
                this.carouselGrid.Children.Clear();
                this.carouselGrid = null;
            }
            base.Dispose(disposing);
        }
    }
}
