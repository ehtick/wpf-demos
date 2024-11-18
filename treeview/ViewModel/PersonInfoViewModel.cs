#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Media;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;
using Syncfusion.Windows.Shared;

namespace syncfusion.treeviewdemos.wpf
{
    public class PersonInfoViewModel
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonInfoViewModel"/> class.
        /// </summary>
        public PersonInfoViewModel()
        {
            this.TreeGridCollection = this.PopulateTreeGridCollection();
            this.TreeViewCollection = this.PopulateTreeViewCollection();
        }
        #endregion

        #region Properties

        private ObservableCollection<PersonInfo> treeGridCollection = new ObservableCollection<PersonInfo>();

        /// <summary>
        /// Gets or sets the person details.
        /// </summary>
        /// <value>The person details.</value>
        public ObservableCollection<PersonInfo> TreeGridCollection
        {
            get { return treeGridCollection; }
            set { treeGridCollection = value; }
        }

        private ObservableCollection<PersonInfo> treeViewCollection = new ObservableCollection<PersonInfo>();

        /// <summary>
        /// Gets or sets the person details.
        /// </summary>
        /// <value>The person details.</value>
        public ObservableCollection<PersonInfo> TreeViewCollection
        {
            get { return treeViewCollection; }
            set { treeViewCollection = value; }
        }

        #endregion

        #region Populate data

        private ObservableCollection<PersonInfo> PopulateTreeGridCollection()
        {
            var accountant1 = new ObservableCollection<PersonInfo>();

            accountant1.Add(new PersonInfo() { FirstName = "Harold", LastName = "Jefferson", ID = 600, DOB = new DateTime(1993, 02, 11), Salary = 40000 });
            accountant1.Add(new PersonInfo() { FirstName = "Truman", LastName = "Monroe", ID = 600, DOB = new DateTime(1992, 10, 18), Salary = 40000 });
            accountant1.Add(new PersonInfo() { FirstName = "Elton", LastName = "Jackson", ID = 600, DOB = new DateTime(1990, 08, 18), Salary = 40000 });
            accountant1.Add(new PersonInfo() { FirstName = "Kennedy", LastName = "Gates", ID = 600, DOB = new DateTime(1990, 05, 16), Salary = 40000 });

            var accountant2 = new ObservableCollection<PersonInfo>();

            accountant2.Add(new PersonInfo() { FirstName = "Larry", LastName = "Madison", ID = 600, DOB = new DateTime(1993, 09, 11), Salary = 40000 });
            accountant2.Add(new PersonInfo() { FirstName = "Peter", LastName = "Monroe", ID = 600, DOB = new DateTime(1995, 07, 13), Salary = 40000 });
            accountant2.Add(new PersonInfo() { FirstName = "David", LastName = "Jackson", ID = 600, DOB = new DateTime(1997, 06, 15), Salary = 40000 });
            accountant2.Add(new PersonInfo() { FirstName = "Barry", LastName = "Warner", ID = 600, DOB = new DateTime(199, 04, 17), Salary = 40000 });

            var manager1 = new ObservableCollection<PersonInfo>();

            manager1.Add(new PersonInfo() { FirstName = "Calvin", LastName = "Hayes", ID = 500, DOB = new DateTime(1996, 10, 21), Salary = 50000 });
            manager1.Add(new PersonInfo() { FirstName = "Warren", LastName = "Garfield", ID = 500, DOB = new DateTime(1990, 02, 26), Salary = 50000 });
            manager1.Add(new PersonInfo() { FirstName = "Woodrow", LastName = "Arthur", ID = 500, DOB = new DateTime(1992, 07, 23), Salary = 50000 });
            manager1.Add(new PersonInfo() { FirstName = "Theodore", LastName = "Cleveland", ID = 500, DOB = new DateTime(1993, 08, 07), Salary = 50000 });

            var manager2 = new ObservableCollection<PersonInfo>();

            manager2.Add(new PersonInfo() { FirstName = "Lyndon", LastName = "Buchanan", ID = 500, DOB = new DateTime(1991, 07, 04), Salary = 50000 });
            manager2.Add(new PersonInfo() { FirstName = "Dwight", LastName = "Johnson", ID = 500, DOB = new DateTime(1991, 12, 02), Salary = 50000 });
            manager2.Add(new PersonInfo() { FirstName = "Harry", LastName = "Potter", ID = 500, DOB = new DateTime(1992, 04, 09), Salary = 50000 });
            manager2.Add(new PersonInfo() { FirstName = "Herbert", LastName = "Grant", ID = 500, DOB = new DateTime(1994, 05, 15), Salary = 50000 });

            var manager3 = new ObservableCollection<PersonInfo>();

            manager3.Add(new PersonInfo() { FirstName = "Calvin", LastName = "Hayes", ID = 500, DOB = new DateTime(1992, 03, 02), Salary = 50000 });
            manager3.Add(new PersonInfo() { FirstName = "Warren", LastName = "Garfield", ID = 500, DOB = new DateTime(1993, 07, 04), Salary = 50000 });
            manager3.Add(new PersonInfo() { FirstName = "Woodrow", LastName = "Arthur", ID = 500, DOB = new DateTime(1995, 08, 24), Salary = 50000 });
            manager3.Add(new PersonInfo() { FirstName = "Theodore", LastName = "Cleveland", ID = 500, DOB = new DateTime(1996, 09, 14), Salary = 50000 });

            var vp_childnodes1 = new ObservableCollection<PersonInfo>();
            vp_childnodes1.Add(new PersonInfo() { FirstName = "Nixon", LastName = "Buren", ID = 400, DOB = new DateTime(1994, 06, 11), Salary = 90000, Children = accountant1 });
            vp_childnodes1.Add(new PersonInfo() { FirstName = "Benjamin", LastName = "Franklin", ID = 400, DOB = new DateTime(1994, 06, 11), Salary = 80000, Children = manager2 });

            var vp_childnodes2 = new ObservableCollection<PersonInfo>();
            vp_childnodes2.Add(new PersonInfo() { FirstName = "Ricky", LastName = "Pointer", ID = 400, DOB = new DateTime(1993, 05, 17), Salary = 90000, Children = manager1 });

            var vp_childnodes3 = new ObservableCollection<PersonInfo>();

            vp_childnodes3.Add(new PersonInfo() { FirstName = "Benjamin", LastName = "Franklin", ID = 400, DOB = new DateTime(1993, 05, 17), Salary = 90000, Children = manager3 });
            vp_childnodes3.Add(new PersonInfo() { FirstName = "Grover", LastName = "Roosevelt", ID = 450, DOB = new DateTime(1993, 05, 17), Salary = 80000, Children = accountant2 });

            var vp_childnodes4 = new ObservableCollection<PersonInfo>();

            vp_childnodes4.Add(new PersonInfo() { FirstName = "Ricky", LastName = "Pointer", ID = 400, DOB = new DateTime(1993, 05, 17), Salary = 90000, Children = manager3 });
            vp_childnodes4.Add(new PersonInfo() { FirstName = "Johny", LastName = "Dermot", ID = 450, DOB = new DateTime(1993, 05, 17), Salary = 80000, Children = accountant2 });

            var vice_president = new ObservableCollection<PersonInfo>();

            vice_president.Add(new PersonInfo() { FirstName = "Rutherford", LastName = "Wilson", ID = 200, DOB = new DateTime(1984, 07, 19), Salary = 150000, Children = vp_childnodes1 });
            vice_president.Add(new PersonInfo() { FirstName = "Ulysses", LastName = "Taft", ID = 200, DOB = new DateTime(1995, 07, 22), Salary = 150000, Children = vp_childnodes2 });
            vice_president.Add(new PersonInfo() { FirstName = "Chester", LastName = "Harding", ID = 200, DOB = new DateTime(1998, 03, 24), Salary = 150000, Children = vp_childnodes3 });
            vice_president.Add(new PersonInfo() { FirstName = "Johny", LastName = "Dermot", ID = 200, DOB = new DateTime(1997, 03, 21), Salary = 150000, Children = vp_childnodes4 });

            return vice_president;
        }

        private ObservableCollection<PersonInfo> PopulateTreeViewCollection()
        {
            var accountant1 = new ObservableCollection<PersonInfo>();

            accountant1.Add(new PersonInfo() { FirstName = "John", LastName = "Washington", ID = 600, DOB = new DateTime(1992, 10, 18), Salary = 40000 });
            accountant1.Add(new PersonInfo() { FirstName = "Thomas", LastName = "Adams", ID = 600, DOB = new DateTime(1990, 08, 18), Salary = 40000 });
            accountant1.Add(new PersonInfo() { FirstName = "James", LastName = "Jefferson", ID = 600, DOB = new DateTime(1990, 05, 16), Salary = 40000 });

            var accountant2 = new ObservableCollection<PersonInfo>();

            accountant2.Add(new PersonInfo() { FirstName = "Larry", LastName = "Madison", ID = 600, DOB = new DateTime(1989, 12, 29), Salary = 40000 });
            accountant2.Add(new PersonInfo() { FirstName = "Peter", LastName = "Monroe", ID = 600, DOB = new DateTime(1990, 11, 30), Salary = 40000 });
            accountant2.Add(new PersonInfo() { FirstName = "David", LastName = "Jackson", ID = 600, DOB = new DateTime(1991, 01, 11), Salary = 40000 });
            accountant2.Add(new PersonInfo() { FirstName = "Barry", LastName = "Warner", ID = 600, DOB = new DateTime(1991, 08, 11), Salary = 40000 });

            var accountant3 = new ObservableCollection<PersonInfo>();

            accountant3.Add(new PersonInfo() { FirstName = "Bill", LastName = "Van", ID = 600, DOB = new DateTime(1992, 03, 16), Salary = 40000 });
            accountant3.Add(new PersonInfo() { FirstName = "Jimmy", LastName = "Gates", ID = 600, DOB = new DateTime(1992, 03, 19), Salary = 40000 });
            accountant3.Add(new PersonInfo() { FirstName = "Gerald", LastName = "Buren", ID = 600, DOB = new DateTime(1996, 03, 27), Salary = 40000 });
            accountant3.Add(new PersonInfo() { FirstName = "Paul", LastName = "Tyler", ID = 600, DOB = new DateTime(1994, 03, 29), Salary = 40000 });

            var manager1 = new ObservableCollection<PersonInfo>();

            manager1.Add(new PersonInfo() { FirstName = "Andrew", LastName = "Richard", ID = 500, DOB = new DateTime(1995, 03, 14), Salary = 50000 });
            manager1.Add(new PersonInfo() { FirstName = "Martin", LastName = "Polk", ID = 500, DOB = new DateTime(1993, 07, 11), Salary = 50000 });
            manager1.Add(new PersonInfo() { FirstName = "Zachary", LastName = "Taylor", ID = 500, DOB = new DateTime(1989, 03, 06), Salary = 50000 });
            manager1.Add(new PersonInfo() { FirstName = "Milton", LastName = "Fillmore", ID = 500, DOB = new DateTime(1988, 06, 20), Salary = 50000 });

            var manager2 = new ObservableCollection<PersonInfo>();

            manager2.Add(new PersonInfo() { FirstName = "Dwayne", LastName = "Douglas", ID = 500, DOB = new DateTime(1995, 03, 14), Salary = 50000 });
            manager2.Add(new PersonInfo() { FirstName = "Sam", LastName = "Harrison", ID = 500, DOB = new DateTime(1993, 07, 11), Salary = 50000 });
            manager2.Add(new PersonInfo() { FirstName = "Jones", LastName = "Lincoln", ID = 500, DOB = new DateTime(1989, 03, 06), Salary = 50000 });
            manager2.Add(new PersonInfo() { FirstName = "Hunter", LastName = "Washington", ID = 500, DOB = new DateTime(1988, 06, 20), Salary = 50000 });

            var manager3 = new ObservableCollection<PersonInfo>();

            manager3.Add(new PersonInfo() { FirstName = "Frank", LastName = "Tyler", ID = 500, DOB = new DateTime(1996, 10, 21), Salary = 50000 });
            manager3.Add(new PersonInfo() { FirstName = "Clint", LastName = "Polk", ID = 500, DOB = new DateTime(1990, 02, 26), Salary = 50000 });
            manager3.Add(new PersonInfo() { FirstName = "Stuart", LastName = "Douglas", ID = 500, DOB = new DateTime(1993, 08, 07), Salary = 50000 });

            var vp_childnodes1 = new ObservableCollection<PersonInfo>();

            vp_childnodes1.Add(new PersonInfo() { FirstName = "Franklin", LastName = "Harrison", ID = 400, DOB = new DateTime(1993, 09, 21), Salary = 90000, Children = manager1 });
            vp_childnodes1.Add(new PersonInfo() { FirstName = "Abraham", LastName = "Lincoln", ID = 450, DOB = new DateTime(1990, 04, 01), Salary = 80000, Children = accountant1 });

            var vp_childnodes2 = new ObservableCollection<PersonInfo>();

            vp_childnodes2.Add(new PersonInfo() { FirstName = "Grover", LastName = "Roosevelt", ID = 450, DOB = new DateTime(1991, 08, 11), Salary = 90000, Children = accountant2 });
            vp_childnodes2.Add(new PersonInfo() { FirstName = "Colin", LastName = "Adams", ID = 450, DOB = new DateTime(1991, 08, 11), Salary = 80000, Children = manager2 });

            var vp_childnodes3 = new ObservableCollection<PersonInfo>();
            vp_childnodes3.Add(new PersonInfo() { FirstName = "Alex", LastName = "Carey", ID = 450, DOB = new DateTime(1992, 03, 27), Salary = 90000, Children = accountant3 });
            vp_childnodes3.Add(new PersonInfo() { FirstName = "Johny", LastName = "Dermot", ID = 450, DOB = new DateTime(1992, 07, 12), Salary = 80000, Children = manager3 });

            var vice_president = new ObservableCollection<PersonInfo>();

            vice_president.Add(new PersonInfo() { FirstName = "Ulysses", LastName = "Taft", ID = 200, DOB = new DateTime(1985, 04, 15), Salary = 150000, Children = vp_childnodes1 });
            vice_president.Add(new PersonInfo() { FirstName = "Richard", LastName = "Taylor", ID = 200, DOB = new DateTime(1984, 07, 19), Salary = 150000, Children = vp_childnodes2 });
            vice_president.Add(new PersonInfo() { FirstName = "George", LastName = "Harrison", ID = 600, DOB = new DateTime(1993, 02, 11), Salary = 150000, Children = vp_childnodes3 });

            return vice_president;
        }

        #endregion
    }
}
