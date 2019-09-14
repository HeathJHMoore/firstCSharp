using System;
using System.Collections.Generic;
using System.Text;

namespace Corporate_Class
{
    class Employee
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }

        public DateTime StartDate { get; set; }

        public Employee(string newName, string jobTitle, DateTime startDate)
        {
            Name = newName;
            JobTitle = jobTitle;
            StartDate = startDate;
        }
    }
}
