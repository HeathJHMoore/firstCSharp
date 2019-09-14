using System;
using System.Collections.Generic;

namespace Corporate_Class
{
    class Program
    {
        public class Company
        {
            /*
                Some readonly properties
            */
            public string Name { get; }
            public DateTime CreatedOn { get; }

            // Create a property for holding a list of current employees
            public List<Employee> employeelist = new List<Employee>();

            // Create a method that allows external code to add an employee
            public void addEmployee(Employee newEmployee)
            {
                employeelist.Add(newEmployee);
            }
            // Create a method that allows external code to remove an employee
            public void removeEmployee(Employee oldEmployee)
            {
                employeelist.Remove(oldEmployee);
            }

            public void printEmployees()
            {
                foreach(Employee employee in employeelist)
                {
                    Console.WriteLine($"{employee.Name} is a {employee.JobTitle} and started here on {employee.StartDate}");
                }
            }
            /*
                Create a constructor method that accepts two arguments:
                    1. The name of the company
                    2. The date it was created

                The constructor will set the value of the public properties
            */

            public Company(string newName, DateTime newDate)
            {
                Name = newName;
                CreatedOn = newDate;
            }
        }

        static void Main(string[] args)
        {
            var Spotify = new Company("Spotify", new DateTime(2010, 8, 9));

            var Billy = new Employee("Billy", "Software Engineer", new DateTime(2017, 2, 3));

            Spotify.addEmployee(Billy);

            Spotify.addEmployee(new Employee("Sarah", "Software Engineer", new DateTime(2018, 4, 5)));

            Spotify.removeEmployee(Billy);

            Spotify.printEmployees();
        }
    }
}
