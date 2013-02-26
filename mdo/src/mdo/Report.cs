#region CopyrightHeader
//
//  Copyright by Contributors
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//         http://www.apache.org/licenses/LICENSE-2.0.txt
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace gov.va.medora.mdo
{
    public class Report
    {
        string caseNumber;
        string id;
        string title;
        string timestamp;
        Author author;
        SiteId facility;
        string _type;
        string _text;

        public Report() { }

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string CaseNumber
        {
            get { return caseNumber; }
            set { caseNumber = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }

        public Author Author
        {
            get { return author; }
            set { author = value; }
        }

        public SiteId Facility
        {
            get { return facility; }
            set { facility = value; }
        }
    }
}
