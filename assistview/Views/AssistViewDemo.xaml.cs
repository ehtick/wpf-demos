#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using syncfusion.assistviewdemo.wpf.ViewModel;
using syncfusion.demoscommon.wpf;
using Syncfusion.SfSkinManager;
using Syncfusion.UI.Xaml.Chat;
using Syncfusion.Windows.Controls;
using Syncfusion.Windows.Shared;
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

namespace syncfusion.assistviewdemo.wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AssistViewDemo : DemoControl
    {
        
        public AssistViewDemo()
        {    
            InitializeComponent();
            var msgs = this.DataContext as AIAssistViewModel;
            msgs.InitAI();
        }

        protected override void Dispose(bool disposing)
        {
            if ((this.DataContext as AIAssistViewModel).assistView != null)
            {
                (this.DataContext as AIAssistViewModel).assistView = null;
            }

            base.Dispose(disposing);
        }

        private void chat_SuggestionSelected(object sender, SuggestionClickedEventArgs e)
        {
            var msgs = chat.DataContext as AIAssistViewModel;
            msgs.Chats.Add(new TextMessage { Text = e.Item.ToString(), DateTime = DateTime.Now, Author = chat.CurrentUser });
        }

        private void chat_MenuItemClicked(object sender, MenuItemClickedEventArgs e)
        {
            var msgs = chat.DataContext as AIAssistViewModel;
            msgs.MenuItemClicked(e);
        }

    }
}