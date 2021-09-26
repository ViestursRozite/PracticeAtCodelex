using System;


namespace Exercise5
{
    class DemonstrateDateClass
    {
        static void Main(string[] args)
        {
            Date date1 = new Date("08", "03", "2021");
            date1.DisplayDate();

            Console.ReadKey();
        }
    }
}
