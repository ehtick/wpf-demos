#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Windows;
using Syncfusion.Windows.Shared;

namespace syncfusion.calculatedemos.wpf
{
    /// <summary>
    /// Interaction logic for AlgebraicExpressions.xaml
    /// </summary>
    public partial class AlgebraicExpressions : ChromelessWindow
    {
        #region API definition

        //Initialize Calculator
        private CalcQuick calculator = null;

        #endregion

        #region Constructor
        public AlgebraicExpressions()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            calculator = new CalcQuick();

            this.calculator["base"] = (3).ToString();
            this.calculator["height"] = (2.5).ToString();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //Register a variable name and its value.
            string name = this.txtName.Text;
            string val = this.txtValue.Text;
            if (name.Length > 0)
                this.calculator[name] = val;

            this.txtSet.Text += name + ": " + val + Environment.NewLine;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string s = calculator.ParseAndCompute(this.txtalg.Text);
                this.lblco.Content = s;
            }
            catch (Exception ex)
            {
                //show error
                this.lblco.Content = ex.Message;
            }
        }
        #endregion
    }
}
