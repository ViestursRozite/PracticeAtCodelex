using System;

namespace Casting
{
    class Program1
    {
        static void Main(string[] args)
        {
            first();
            second();
            Console.ReadKey();
        }

        static void first()
        {
            String a = "1";
            int b = 2;
            int c = 3;
            double d = 4;
            float e = 5;

            int aInt, bInt, cInt, dInt, eInt;
            aInt = Int32.Parse(a);
            bInt = b;
            cInt = c;
            dInt = Convert.ToInt32(d);
            eInt = Convert.ToInt32(e);

            int sum = aInt + bInt + cInt + dInt + eInt;

            Console.WriteLine(sum);
        }

        static void second()
        {
            String a = "1";
            int b = 2;
            int c = 3;
            double d = 4.2;
            float e = 5.3f;

            int aInt, bInt, cInt, dInt, eInt;
            aInt = Int32.Parse(a);
            bInt = b;
            cInt = c;
            dInt = Convert.ToInt32(d);
            eInt = Convert.ToInt32(e);

            int sum = aInt + bInt + cInt + dInt + eInt;

            Console.WriteLine(sum);
        }
    }
}
