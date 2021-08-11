using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {

            var firstAccount = new SavingsAccount(AskForString("Give me the name of the first savings account"),
                AskForDecimal("enter starting balance"), 
                AskForDecimal("Enter a number representing yearly interest for this account(5% = 0.05)"));
            var secondAccount = new SavingsAccount(AskForString("Give me the name of the second savings account"), 
                AskForDecimal("enter starting balance"), 
                AskForDecimal("Enter a number representing yearly interest for this account(5% = 0.05)"));

            Console.WriteLine(firstAccount);
            Console.WriteLine(secondAccount);

            decimal monthsPassed = AskForDecimal("how many full months do we hold for?");

            firstAccount.CalcInterestMonth(monthsPassed);
            secondAccount.CalcInterestMonth(monthsPassed);

            Console.WriteLine(firstAccount);
            Console.WriteLine(secondAccount);

            Console.WriteLine("Lets simulate a six month period of activity, press any key");
            Console.ReadKey();

            int deposits = 0;
            int withdrawals = 0;

            decimal deposited = 0;
            decimal withdrawn = 0;

            for (int i = 0; i < 6; i++)
            {
                decimal deposit = AskForDecimal($"how much money do we deposit in the first account?\n month: {i + 1}/6");
                deposited += deposit;
                if (deposit != 0) deposits++;
                firstAccount.deposit(deposit);
                firstAccount.balance();

                decimal withdraw = AskForDecimal($"how much do you take out?\n month: {i + 1}/6");
                withdrawn += withdraw;
                if (withdraw != 0) withdrawals++;
                firstAccount.withdrawal(withdraw);
                firstAccount.balance();

                Console.WriteLine("Gain from interest:");
                decimal holder = firstAccount.balance(); 
                firstAccount.CalcInterestMonth(1);
                Console.WriteLine(firstAccount.balance() - holder);

                Console.WriteLine("Remainder:");
                Console.WriteLine(firstAccount.balance());
            }

            Console.WriteLine("deposits: " + deposits);
            Console.WriteLine("withdrawals: " + withdrawals);

            Console.WriteLine("total deposited: " + deposited);
            Console.WriteLine("total withdrawn: " + withdrawn);

            Console.ReadKey();
        }

        public static string AskForString(string sayThisToUser)
        {
            Console.WriteLine(sayThisToUser);
            string input = "";
            input = Console.ReadLine();
            if (input.Equals(""))
            {
                Console.WriteLine("Try again");
                AskForString(sayThisToUser);
            }
            return input;
        }

        public static decimal AskForDecimal(string sayThisToUser)
        {
            Console.WriteLine(sayThisToUser);
            double input = -1;
            double.TryParse(Console.ReadLine(), out input);
            if ( input < 0)
            {
                Console.WriteLine("Try again");
                AskForString(sayThisToUser);
            }
            return (decimal)input;
        }

        public static void Transfer(SavingsAccount from, SavingsAccount to, decimal howMuch)
        {
            to.deposit(from.withdrawal(howMuch));
        }
    }
}
