using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    class Student: Person
    {
        double Gpa { get; set; }
        public Student(double gpa, string firstName, string lastName, string address, int id)
        {
            base.FirstName = firstName;
            base.LastName = lastName;
            base.Address = address;
            base.Id = id;
            this.Gpa = gpa;
        }
        public Student(double gpa)
        {
            this.Gpa = gpa;
        }

        new public void Display()
        {
            base.Display();

            Console.WriteLine($"Gpa: {this.Gpa}");
        }
    }
}
