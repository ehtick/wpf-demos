#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace syncfusion.mapdemos.wpf
{
    using syncfusion.demoscommon.wpf;
    using System.Windows.Media;

    /// <summary>
    /// Represents information about a geographic location, including its name, details, coordinates, and address.
    /// </summary>
    public class LocationInfo
    {
        /// <summary>
        /// Gets or sets the name of the location.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets additional details about the location.
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// Gets or sets the longitude coordinate of the location.
        /// </summary>
        public string Longitude { get; set; }

        /// <summary>
        /// Gets or sets the latitude coordinate of the location.
        /// </summary>
        public string Latitude { get; set; }

        /// <summary>
        /// Gets or sets the address of the location.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the image source.
        /// </summary>
        public ImageSource ImageSource { get; set; }

        /// <summary>
        /// Gets the credential valid status.
        /// </summary>
        public bool IsOnline
        {
            get { return AISettings.IsCredentialValid; }
        }
    }
}