using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Account;

namespace BankAccount
{
    class Program10
    {
        static void Main(string[] args)
        {
            SavingsAccount test1 = new SavingsAccount("Jon's account", 550m);
            Console.WriteLine(ShowUserNameAndBalance(test1));
            Console.ReadKey();
        }

        public static string ShowUserNameAndBalance(SavingsAccount account)
        {
            string minus = account.Balance < 0 ? "-" : "";
            return $"{account.Name}, {minus}${account.Balance.ToString("0.00")}";
        }
    }
}
