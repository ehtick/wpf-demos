#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syncfusion.mapdemos.wpf
{
    public class ElectionResultViewModel
    {
        private ObservableCollection<ElectionData> electionResults;
        public ObservableCollection<ElectionData> ElectionResults
        {
            get { return electionResults; }
            set { electionResults = value; }
        }
        public ElectionResultViewModel()
        {
            ElectionResults = new ObservableCollection<ElectionData>
            {
                new ElectionData { State = "Alabama", Candidate = "Romney", Electors = 9 },
                new ElectionData { State = "Alaska", Candidate = "Romney", Electors = 3 },
                new ElectionData { State = "Arizona", Candidate = "Romney", Electors = 11 },
                new ElectionData { State = "Arkansas", Candidate = "Romney", Electors = 6 },
                new ElectionData { State = "California", Candidate = "Obama", Electors = 55 },
                new ElectionData { State = "Colorado", Candidate = "Obama", Electors = 9 },
                new ElectionData { State = "Connecticut", Candidate = "Obama", Electors = 7 },
                new ElectionData { State = "Delaware", Candidate = "Obama", Electors = 3 },
                new ElectionData { State = "District of Columbia", Candidate = "Obama", Electors = 3 },
                new ElectionData { State = "Florida", Candidate = "Obama", Electors = 29 },
                new ElectionData { State = "Georgia", Candidate = "Romney", Electors = 16 },
                new ElectionData { State = "Hawaii", Candidate = "Obama", Electors = 4 },
                new ElectionData { State = "Idaho", Candidate = "Romney", Electors = 4 },
                new ElectionData { State = "Illinois", Candidate = "Obama", Electors = 20 },
                new ElectionData { State = "Indiana", Candidate = "Romney", Electors = 11 },
                new ElectionData { State = "Iowa", Candidate = "Obama", Electors = 6 },
                new ElectionData { State = "Kansas", Candidate = "Romney", Electors = 6 },
                new ElectionData { State = "Kentucky", Candidate = "Romney", Electors = 8 },
                new ElectionData { State = "Louisiana", Candidate = "Romney", Electors = 8 },
                new ElectionData { State = "Maine", Candidate = "Obama", Electors = 4 },
                new ElectionData { State = "Maryland", Candidate = "Obama", Electors = 10 },
                new ElectionData { State = "Massachusetts", Candidate = "Obama", Electors = 11 },
                new ElectionData { State = "Michigan", Candidate = "Obama", Electors = 16 },
                new ElectionData { State = "Minnesota", Candidate = "Obama", Electors = 10 },
                new ElectionData { State = "Mississippi", Candidate = "Romney", Electors = 6 },
                new ElectionData { State = "Missouri", Candidate = "Romney", Electors = 10 },
                new ElectionData { State = "Montana", Candidate = "Romney", Electors = 3 },
                new ElectionData { State = "Nebraska", Candidate = "Romney", Electors = 5 },
                new ElectionData { State = "Nevada", Candidate = "Obama", Electors = 6 },
                new ElectionData { State = "New Hampshire", Candidate = "Obama", Electors = 4 },
                new ElectionData { State = "New Jersey", Candidate = "Obama", Electors = 14 },
                new ElectionData { State = "New Mexico", Candidate = "Obama", Electors = 5 },
                new ElectionData { State = "New York", Candidate = "Obama", Electors = 29 },
                new ElectionData { State = "North Carolina", Candidate = "Romney", Electors = 15 },
                new ElectionData { State = "North Dakota", Candidate = "Romney", Electors = 3 },
                new ElectionData { State = "Ohio", Candidate = "Obama", Electors = 18 },
                new ElectionData { State = "Oklahoma", Candidate = "Romney", Electors = 7 },
                new ElectionData { State = "Oregon", Candidate = "Obama", Electors = 7 },
                new ElectionData { State = "Pennsylvania", Candidate = "Obama", Electors = 20 },
                new ElectionData { State = "Rhode Island", Candidate = "Obama", Electors = 4 },
                new ElectionData { State = "South Carolina", Candidate = "Romney", Electors = 9 },
                new ElectionData { State = "South Dakota", Candidate = "Romney", Electors = 3 },
                new ElectionData { State = "Tennessee", Candidate = "Romney", Electors = 11 },
                new ElectionData { State = "Texas", Candidate = "Romney", Electors = 38 },
                new ElectionData { State = "Utah", Candidate = "Romney", Electors = 6 },
                new ElectionData { State = "Vermont", Candidate = "Obama", Electors = 3 },
                new ElectionData { State = "Virginia", Candidate = "Obama", Electors = 13 },
                new ElectionData { State = "Washington", Candidate = "Obama", Electors = 12 },
                new ElectionData { State = "West Virginia", Candidate = "Romney", Electors = 5 },
                new ElectionData { State = "Wisconsin", Candidate = "Obama", Electors = 10 },
                new ElectionData { State = "Wyoming", Candidate = "Romney", Electors = 3 }
            };
        }
    }
}
