using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    public class Person
    {
        protected string FirstName { get; set; }
        protected string LastName{ get; set; }
        protected string Address { get; set; }
        protected int Id { get; set; }

        Person(string firstName, string lastName, string address, int id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Id = id;
        }
        public Person() 
        {
            this.FirstName = "Name not set";
            this.LastName = "Last name not set";
            this.Address = "Addres not set";
            this.Id = -1;
        }

        public void Display()
        {
            Console.WriteLine($"First name: {this.FirstName}\n" +
                $"Last name: {this.LastName}\n" +
                $"Address: {this.Address}\n" +
                $"Id: {this.Id}");
        }
    }
}
