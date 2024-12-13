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

namespace syncfusion.datagriddemos.wpf
{
    public class EmployeeDetails : NotificationObject
    {
        private System.Nullable<int> _OrderID;

        /// <summary>
        /// Gets or sets the order ID.
        /// </summary>
        /// <value>The order ID.</value>
        public System.Nullable<int> OrderID
        {
            get
            {
                return this._OrderID;
            }
            set
            {
                this._OrderID = value;
                RaisePropertyChanged("OrderID");
            }
        }

        private System.Nullable<int> _productID;

        /// <summary>
        /// Gets or sets the ProductID
        /// </summary>
        /// <value>The ProductID</value>
        public System.Nullable<int> ProductID
        {
            get
            {
                return this._productID;
            }
            set
            {
                this._productID = value;
                RaisePropertyChanged("ProductID");
            }
        }

        private string _customerID;
        /// <summary>
        /// Gets or Sets the CustomerID
        /// </summary>
        public string CustomerID
        {
            get
            {
                return this._customerID;
            }
            set
            {
                this._customerID = value;
                RaisePropertyChanged("CustomerID");
            }
        }

        private string _Postalcode;
        public string PostalCode
        {
            get
            {
                return this._Postalcode;
            }
            set
            {
                this._Postalcode = value;
                RaisePropertyChanged("ProductName");
            }
        }
        private int _EmployeeID;

        /// <summary>
        /// Gets or sets the employee ID.
        /// </summary>
        /// <value>The employee ID.</value>
        public int EmployeeID
        {
            get
            {
                return this._EmployeeID;
            }
            set
            {
                this._EmployeeID = value;
                RaisePropertyChanged("EmployeeID");
            }
        }

        private string _Name;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                RaisePropertyChanged("Name");
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeDetails"/> class.
        /// </summary>
        /// <param name="or">The or.</param>
        /// <param name="emp">The emp.</param>
        /// <param name="nam">The nam.</param>
        public EmployeeDetails(int or, int emp, string nam, string custID, int ProdID, string postalcode)
        {
            this.EmployeeID = emp;
            this.ProductID = ProdID;
            this.PostalCode = postalcode;
            this.OrderID = or;
            this.CustomerID = custID;
            this.Name = nam;
        }
         
    }
}

