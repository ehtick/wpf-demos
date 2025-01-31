#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;

namespace syncfusion.visualstudiodemo.wpf
{
    public class ErrorListModel
    {
        public String Number { get; set; }
        public String Description { get; set; }
        public String File { get; set; }
        public String Line { get; set; }
        public String Column { get; set; }
        public String Project { get; set; }
        public ErrorListModel()
        {
        }
    }
}
