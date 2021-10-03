using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program8
    {
        static void Main(string[] args)
        {
            PhoneBook.PhoneDirectory PhoneBook = new PhoneBook.PhoneDirectory();

            PhoneBook.PhoneEntry entry1 = new PhoneBook.PhoneEntry("Mike", "256985632");
            PhoneBook.PhoneEntry entry2 = new PhoneBook.PhoneEntry("Bobby", "854145115");
            PhoneBook.PhoneEntry entry3 = new PhoneBook.PhoneEntry("Jonny", "951211541");

            PhoneBook.PutNumber(entry1);
            PhoneBook.PutNumber(entry2);
            PhoneBook.PutNumber(entry3);
            PhoneBook.PutNumber("Adam", "288914545");
            PhoneBook.PutNumber("Ann", "845215519");

            foreach(KeyValuePair<string, string> kvp in PhoneBook.GetDict())
            {
                Console.WriteLine($"Name: \"{kvp.Key}\", Number: \"{kvp.Value}\"");
            }
            Console.ReadKey();
        }
    }
}
