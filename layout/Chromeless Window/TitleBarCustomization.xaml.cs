#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.SfSkinManager;
using System;
using System.ComponentModel;

namespace syncfusion.layoutdemos.wpf
{
    /// <summary>
    /// Code behind logic for MainWindow.xaml
    /// </summary>
    public partial class TitleBarCustomization
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TitleBarCustomization" /> class.
        /// </summary>
        public TitleBarCustomization()
        {
            InitializeComponent();
        }

        public TitleBarCustomization(string themename)
        {
            SfSkinManager.SetTheme(this, new Theme() { ThemeName = themename });
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            // Release all managed resources
            if(this.dataGrid != null)
            {
                this.dataGrid.Dispose();
                this.dataGrid = null;
            }
            if (TitleBarCustomizationViewModel.dataGrid != null)
            {
                TitleBarCustomizationViewModel.dataGrid.Dispose();
                TitleBarCustomizationViewModel.dataGrid = null;
            }
            if (this.searchText != null)
                this.searchText = null;
            if (this.findPrevious != null)
                this.findPrevious = null;
            if (this.findNext != null)
                this.findNext = null;
            if (this.help != null)
                this.help = null;
            base.OnClosing(e);
        }

    }
}
