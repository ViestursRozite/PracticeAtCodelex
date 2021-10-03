using System;

namespace Exercise2
{
    class Program2
    {       
        private static void Main(string[] args)
        {
            int[] myArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var sum = 0;
            //                   ↓adds '[]' to    ↓
            Console.WriteLine("[{0}]", string.Join(", ", myArray));
            
            Console.WriteLine("Please enter a min number to start summing from (included)");
            int minNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number to end summation at (excluded)");
            int maxNumber = int.Parse(Console.ReadLine());

            foreach (int number in myArray) 
            {
                if(number >= minNumber && number < maxNumber) 
                {
                    sum += number;
                }
            }

            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
            }
        }
}
