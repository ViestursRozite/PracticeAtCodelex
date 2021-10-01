using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    class Employee: Person
    {
        string JobTitle { get; set; }
        public Employee(string jobTitle, string firstName, string lastName, string address, int id)
        {
            base.FirstName = firstName;
            base.LastName = lastName;
            base.Address = address;
            base.Id = id;
            this.JobTitle = jobTitle;
        }
        public Employee(string jobTitle)
        {
            this.JobTitle = jobTitle;
        }
        new public void Display()
        {
            base.Display();

            Console.WriteLine($"Job title: {this.JobTitle}");
        }
    }
}
