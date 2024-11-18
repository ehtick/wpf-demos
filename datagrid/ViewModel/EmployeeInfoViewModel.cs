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
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace syncfusion.datagriddemos.wpf
{
    public class EmployeeInfoViewModel : NotificationObject,IDisposable
    {
        Random r = new Random();
        private ObservableCollection<EmployeeInfo> _employeeDetails = new ObservableCollection<EmployeeInfo>();
        private ObservableCollection<EmployeeInfo> _employees = new ObservableCollection<EmployeeInfo>();
        internal Dictionary<string, string> loginID = new Dictionary<string, string>();
        internal Dictionary<string, string> gender = new Dictionary<string, string>();
        private ObservableCollection<string> _queries = new ObservableCollection<string>();

        public EmployeeInfoViewModel()
        {
            PopulateData();
            PopulateQueries();
            this.EmployeeDetails = GetEmployeesDetails(10000);
            this.Employees = GetEmployeesDetails(200);
        }

        public ObservableCollection<EmployeeInfo> EmployeeDetails
        {
            get
            {
                return _employeeDetails;
            }
            set
            {
                _employeeDetails = value;
            }
        }

        public ObservableCollection<EmployeeInfo> Employees
        {
            get
            {
                return _employees;
            }
            set
            {
                _employees = value;
            }
        }

        public ObservableCollection<string> Queries
        {
            get { return _queries; }
            set { _queries = value; }
        }

        internal FilterChanged filterChanged;
        private ICommand textchanged;

        public ICommand TextChanged
        {
            get { return new DelegateCommand<object>(TextChangeEvent, args => true); }
            set { textchanged = value; RaisePropertyChanged("TextChanged"); }
        }

        public ICommand ComboChanged
        {
            get { return new DelegateCommand<object>(ComboxChangedEvent, args => { return true; }); }
        }

        public ICommand FilterComboChanged
        {
            get { return new DelegateCommand<object>(FilterComboxChangedEvent, args => { return true; }); }
        }

        private void FilterComboxChangedEvent(object pram)
        {
            if (pram != null)
            {
                this.FilterOption = (pram as ComboBoxItem).Content.ToString();
                filterChanged();
            }
        }

        private void ComboxChangedEvent(object pram)
        {
            if (pram != null)
            {
                this.FilterCondition = (pram as ComboBoxItem).Content.ToString();
                filterChanged();
            }
        }

        private void TextChangeEvent(object pram)
        {
            if (pram != null)
            {
                this.FilterText = pram.ToString();
                filterChanged();
            }
        }

        private bool MakeStringFilter(EmployeeInfo o, string option, string condition)
        {
            var value = o.GetType().GetProperty(option);
            var exactValue = value.GetValue(o, null);
            exactValue = exactValue.ToString().ToLower();
            string text = FilterText.ToLower();
            var methods = typeof(string).GetMethods();
            if (methods.Count() != 0)
            {
                var methodInfo = methods.FirstOrDefault(method => method.Name == condition);
                bool result1 = (bool)methodInfo.Invoke(exactValue, new object[] { text });
                return result1;
            }
            else
                return false;
        }

        private bool MakeNumericFilter(EmployeeInfo o, string option, string condition)
        {
            var value = o.GetType().GetProperty(option);
            var exactValue = value.GetValue(o, null);
            double res;
            bool checkNumeric = double.TryParse(exactValue.ToString(), out res);
            if (checkNumeric)
            {
                switch (condition)
                {
                    case "Equals":
                        if (Convert.ToDouble(exactValue) == (Convert.ToDouble(FilterText)))
                            return true;
                        break;
                    case "GreaterThan":
                        if (Convert.ToDouble(exactValue) > Convert.ToDouble(FilterText))
                            return true;
                        break;
                    case "LessThan":
                        if (Convert.ToDouble(exactValue) < Convert.ToDouble(FilterText))
                            return true;
                        break;
                    case "NotEquals":
                        if (Convert.ToDouble(FilterText) != Convert.ToDouble(exactValue))
                            return true;
                        break;
                }
            }
            return false;
        }

        public bool FilerRecords(object o)
        {
            double res;
            bool checkNumeric = double.TryParse(FilterText, out res);
            var item = o as EmployeeInfo;
            if (item != null && FilterText.Equals(""))
            {
                return true;
            }
            else
            {
                if (item != null)
                {
                    if (checkNumeric && !FilterOption.Equals("All Columns"))
                    {
                        if (FilterCondition == null || FilterCondition.Equals("Contains") || FilterCondition.Equals("StartsWith") || FilterCondition.Equals("EndsWith"))
                            FilterCondition = "Equals";
                        bool result = MakeNumericFilter(item, FilterOption, FilterCondition);
                        return result;
                    }
                    else if (FilterOption.Equals("All Columns"))
                    {
                        if (item.Name.ToLower().Contains(FilterText.ToLower()) ||
                            item.Title.ToLower().Contains(FilterText.ToLower()) ||
                            item.Salary.ToString().ToLower().Contains(FilterText.ToLower()) || item.EmployeeID.ToString().ToLower().Contains(FilterText.ToLower()) ||
                            item.Gender.ToLower().Contains(FilterText.ToLower()))
                            return true;
                        return false;
                    }
                    else
                    {
                        if (FilterCondition == null || FilterCondition.Equals("Equals") || FilterCondition.Equals("LessThan") || FilterCondition.Equals("GreaterThan") || FilterCondition.Equals("NotEquals"))
                            FilterCondition = "Contains";
                        bool result = MakeStringFilter(item, FilterOption, FilterCondition);
                        return result;
                    }
                }
            }
            return false;
        }

        private string filterOption = "All Columns";

        public string FilterOption
        {
            get { return filterOption; }
            set
            {
                if (value == "All Columns")
                    filterOption = value;
                else
                    filterOption = value.Replace(" ", "");
                if (filterOption == "Name" || filterOption == "Title")
                    FilterCondition = "Contains";
                else if (filterOption == "Salary" || filterOption == "EmployeeID")
                    FilterCondition = "Equals";

                if (filterChanged != null)
                    filterChanged();
                RaisePropertyChanged("FilterOption");
            }
        }

        private string filterText = string.Empty;

        public string FilterText
        {
            get { return filterText; }
            set
            {
                filterText = value;
                if (filterChanged != null)
                    filterChanged();
                RaisePropertyChanged("FilterText");
            }
        }

        private string filterCondition;

        public string FilterCondition
        {
            get { return filterCondition; }
            set
            {
                filterCondition = value.Replace(" ", "");
                if (filterChanged != null)
                    filterChanged();
                RaisePropertyChanged("FilterCondition");
            }
        }

        internal delegate void FilterChanged();
        public ObservableCollection<EmployeeInfo> GetEmployeesDetails(int count)
        {
            var employees = new ObservableCollection<EmployeeInfo>();
            for (var i = 1; i < count; i++)
            {
                employees.Add(GetEmployee(i));
            }
            return employees;
        }

        internal List<EmployeeInfo> GetEmployeesList(int count)
        {
            var employees = new List<EmployeeInfo>();
            for (var i = 1; i < count; i++)
            {
                employees.Add(GetEmployee(i));
            }
            return employees;
        }

        public EmployeeInfo GetEmployee(int i)
        {
            var name = EmployeeName[r.Next(EmployeeName.Count() - 1)];
            return new EmployeeInfo()
            {
                EmployeeID = 1000 + i,
                Name = name,
                Rating = r.Next(4, 10),
                ContactID = r.Next(1001, 2000),
                Gender = gender[name],
                Title = title[r.Next(title.Count() - 1)],
                BirthDate = new DateTime(r.Next(1975, 1985), r.Next(1, 12), r.Next(1, 28)),
                SickLeaveHours = r.Next(15, 70),
                Salary = new decimal(Math.Round(r.NextDouble() * 6000.5, 2))
            };
        }

        internal void PopulateData()
        {
            gender.Add("Sean Jacobson", "Male");
            gender.Add("Phyllis Allen", "Male");
            gender.Add("Marvin Allen", "Male");
            gender.Add("Michael Allen", "Male");
            gender.Add("Cecil Allison", "Male");
            gender.Add("Oscar Alpuerto", "Male");
            gender.Add("Sandra Altamirano", "Female");
            gender.Add("Selena Alvarad", "Female");
            gender.Add("Emilio Alvaro", "Female");
            gender.Add("Maxwell Amland", "Male");
            gender.Add("Mae Anderson", "Male");
            gender.Add("Ramona Antrim", "Female");
            gender.Add("Sabria Appelbaum", "Male");
            gender.Add("Hannah Arakawa", "Male");
            gender.Add("Kyley Arbelaez", "Male");
            gender.Add("Tom Johnston", "Female");
            gender.Add("Thomas Armstrong", "Female");
            gender.Add("John Arthur", "Male");
            gender.Add("Chris Ashton", "Female");
            gender.Add("Teresa Atkinson", "Male");
            gender.Add("John Ault", "Male");
            gender.Add("Robert Avalos", "Male");
            gender.Add("Stephen Ayers", "Male");
            gender.Add("Phillip Bacalzo", "Male");
            gender.Add("Gustavo Achong", "Male");
            gender.Add("Catherine Abel", "Male");
            gender.Add("Kim Abercrombie", "Male");
            gender.Add("Humberto Acevedo", "Male");
            gender.Add("Pilar Ackerman", "Male");
            gender.Add("Frances Adams", "Female");
            gender.Add("Margar Smith", "Male");
            gender.Add("Carla Adams", "Male");
            gender.Add("Jay Adams", "Male");
            gender.Add("Ronald Adina", "Female");
            gender.Add("Samuel Agcaoili", "Male");
            gender.Add("James Aguilar", "Female");
            gender.Add("Robert Ahlering", "Male");
            gender.Add("Francois Ferrier", "Male");
            gender.Add("Kim Akers", "Male");
            gender.Add("Lili Alameda", "Female");
            gender.Add("Amy Alberts", "Male");
            gender.Add("Anna Albright", "Female");
            gender.Add("Milton Albury", "Male");
            gender.Add("Paul Alcorn", "Male");
            gender.Add("Gregory Alderson", "Male");
            gender.Add("J. Phillip Alexander", "Male");
            gender.Add("Michelle Alexander", "Male");
            gender.Add("Daniel Blanco", "Male");
            gender.Add("Cory Booth", "Male");
            gender.Add("James Bailey", "Female");

            loginID.Add("Sean Jacobson", "sean2");
            loginID.Add("Phyllis Allen", "phyllis0");
            loginID.Add("Marvin Allen", "marvin0");
            loginID.Add("Michael Allen", "michael10");
            loginID.Add("Cecil Allison", "cecil0");
            loginID.Add("Oscar Alpuerto", "oscar0");
            loginID.Add("Sandra Altamirano", "sandra1");
            loginID.Add("Selena Alvarad", "selena0");
            loginID.Add("Emilio Alvaro", "emilio0");
            loginID.Add("Maxwell Amland", "maxwell0");
            loginID.Add("Mae Anderson", "mae0");
            loginID.Add("Ramona Antrim", "ramona0");
            loginID.Add("Sabria Appelbaum", "sabria0");
            loginID.Add("Hannah Arakawa", "hannah0");
            loginID.Add("Kyley Arbelaez", "kyley0");
            loginID.Add("Tom Johnston", "tom1");
            loginID.Add("Thomas Armstrong", "thomas1");
            loginID.Add("John Arthur", "john6");
            loginID.Add("Chris Ashton", "chris3");
            loginID.Add("Teresa Atkinson", "teresa0");
            loginID.Add("John Ault", "john7");
            loginID.Add("Robert Avalos", "robert2");
            loginID.Add("Stephen Ayers", "stephen1");
            loginID.Add("Phillip Bacalzo", "phillip0");
            loginID.Add("Gustavo Achong", "gustavo0");
            loginID.Add("Catherine Abel", "catherine0");
            loginID.Add("Kim Abercrombie", "kim2");
            loginID.Add("Humberto Acevedo", "humberto0");
            loginID.Add("Pilar Ackerman", "pilar1");
            loginID.Add("Frances Adams", "frances0");
            loginID.Add("Margar Smith", "margaret0");
            loginID.Add("Carla Adams", "carla0");
            loginID.Add("Jay Adams", "jay1");
            loginID.Add("Ronald Adina", "ronald0");
            loginID.Add("Samuel Agcaoili", "samuel0");
            loginID.Add("James Aguilar", "james2");
            loginID.Add("Robert Ahlering", "robert1");
            loginID.Add("Francois Ferrier", "françois1");
            loginID.Add("Kim Akers", "kim3");
            loginID.Add("Lili Alameda", "lili0");
            loginID.Add("Amy Alberts", "amy1");
            loginID.Add("Anna Albright", "anna0");
            loginID.Add("Milton Albury", "milton0");
            loginID.Add("Paul Alcorn", "paul2");
            loginID.Add("Gregory Alderson", "gregory0");
            loginID.Add("J. Phillip Alexander", "jphillip0");
            loginID.Add("Michelle Alexander", "michelle0");
            loginID.Add("Daniel Blanco", "daniel0");
            loginID.Add("Cory Booth", "cory0");
            loginID.Add("James Bailey", "james3");

        }

        internal void PopulateQueries()
        {
            _queries.Add("Show the male employees whose rating is more than 5");
            _queries.Add("Show me the Engineering Manager whose sick leave hours less than 30 hours");
            _queries.Add("Show me the birthdate between 11/11/1975 to 11/11/1980");
            _queries.Add("Show me the Design Engineer based on the Contact ID from 1100 to 1200");
            _queries.Add("Show me the Female Design Engineer whose birth date is after 11/12/1975");
            _queries.Add("Show me all the employees who earn more than $2,500");
            _queries.Add("Show me the EmployeeID from 1001 to 1020 and the title should be Production Technician - WC10");
            _queries.Add("List the employees who have taken sick leave for only three days");
            _queries.Add("List the employees who are over 40 years old");
            _queries.Add("Find the Design Engineer whose name starts with K");
            _queries.Add("Show me the female employees who are over 45 years old");
        }

        internal string[] title = new string[]
            {
                "Marketing Assistant",
                "Engineering Manager",
                "Senior Tool Designer",
                "Tool Designer",
                "Marketing Manager",
                "Production Supervisor - WC60",
                "Production Technician - WC10",
                "Design Engineer",
                "Production Technician - WC10",
                "Design Engineer",
                "Vice President of Engineering",
                "Production Technician - WC10",
                "Production Supervisor - WC50",
                "Production Technician - WC10",
                "Production Supervisor - WC60",
                "Production Technician - WC10",
                "Production Supervisor - WC60",
                "Production Technician - WC10",
                "Production Technician - WC30",
                "Production Control Manager",
                "Production Technician - WC45",
                "Production Technician - WC45",
                "Production Technician - WC30",
                "Production Supervisor - WC10",
                "Production Technician - WC20",
                "Production Technician - WC40",
                "Network Administrator",
                "Production Technician - WC50",
                "Human Resources Manager",
                "Production Technician - WC40",
                "Production Technician - WC30",
                "Production Technician - WC30",
                "Stocker",
                "Shipping and Receiving Clerk",
                "Production Technician - WC50",
                "Production Technician - WC60",
                "Production Supervisor - WC50",
                "Production Technician - WC20",
                "Production Technician - WC45",
                "Quality Assurance Supervisor",
                "Information Services Manager",
                "Production Technician - WC50",
                "Master Scheduler",
                "Production Technician - WC40",
                "Marketing Specialist",
                "Recruiter",
                "Production Technician - WC50",
                "Maintenance Supervisor",
                "Production Technician - WC30",
            };

        internal string[] EmployeeName = new string[]
            {
                "Sean Jacobson",
                "Phyllis Allen",
                "Marvin Allen",
                "Michael Allen",
                "Cecil Allison",
                "Oscar Alpuerto",
                "Sandra Altamirano",
                "Selena Alvarad",
                "Emilio Alvaro",
                "Maxwell Amland",
                "Mae Anderson",
                "Ramona Antrim",
                "Sabria Appelbaum",
                "Hannah Arakawa",
                "Kyley Arbelaez",
                "Tom Johnston",
                "Thomas Armstrong",
                "John Arthur",
                "Chris Ashton",
                "Teresa Atkinson",
                "John Ault",
                "Robert Avalos",
                "Stephen Ayers",
                "Phillip Bacalzo",
                "Gustavo Achong",
                "Catherine Abel",
                "Kim Abercrombie",
                "Humberto Acevedo",
                "Pilar Ackerman",
                "Frances Adams",
                "Margar Smith",
                "Carla Adams",
                "Jay Adams",
                "Ronald Adina",
                "Samuel Agcaoili",
                "James Aguilar",
                "Robert Ahlering",
                "Francois Ferrier",
                "Kim Akers",
                "Lili Alameda",
                "Amy Alberts",
                "Anna Albright",
                "Milton Albury",
                "Paul Alcorn",
                "Gregory Alderson",
                "J. Phillip Alexander",
                "Michelle Alexander",
                "Daniel Blanco",
                "Cory Booth",
                "James Bailey"
            };

        #region IDisposable Members

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (this.filterChanged != null)
            {
                this.filterChanged -= this.filterChanged;
            }

            if (this.EmployeeDetails != null)
            {
                this.EmployeeDetails.Clear();
                this.EmployeeDetails = null;
            }
        }

        #endregion

    }
}
