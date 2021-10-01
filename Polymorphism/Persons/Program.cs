using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(3);
            Student student2 = new Student(4, "Adam", "Biggs", "Main Street 1", 2558522);

            Employee employee1 = new Employee("Programmer");
            Employee employee2 = new Employee("Coder", "Jon", "Smalls", "Baker street 2", 96335);

            student1.Display();
            Console.WriteLine();

            student2.Display();
            Console.WriteLine();

            employee1.Display();
            Console.WriteLine();

            employee2.Display();

            Console.ReadKey();
        }
    }
}