using System;

namespace NumberSquare
{
    class Program10
    {
        public static void LeftShiftArray<T>(T[] arr, int shift)//I stole this
        {
            shift = shift % arr.Length;//rotate less than 1 rotation
            T[] buffer = new T[shift];//make buffer array 
            Array.Copy(arr, buffer, shift);//make the buffer[] of lenght 'shift', take data from my arr
            //write to my arr, starting at index 'shift', from my arr starting at ind 0 up to shift distance away from the end
            Array.Copy(arr, shift, arr, 0, arr.Length - shift);
            Array.Copy(buffer, 0, arr, arr.Length - shift, shift);//fill the remaining positions of my arr from buffer
        }
        public static int makePlayerWriteInput(int option = 1)//returns int, talks to player
        {
            string option1 = $"Enter min:";
            string option2 = $"Enter max:";
            if (option == 1) Console.WriteLine(option1);
            if (option == 2) Console.WriteLine(option2);

            int answer = 0;
            int.TryParse(Console.ReadLine(), out answer);

            return answer;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Lets draw some squares\n" +
                "I need 2 numbers a min and a max\n" +
                "the square will be as big as the difference between inputs + 1\n");

            int min = makePlayerWriteInput(1);
            int max = makePlayerWriteInput(2);
            int diff = max - min;
            diff += 1;//to make 'max' inclusive

            int[] numsHolder = new int[diff];//serves as each line
            for (int i = 0; i < diff; i++)
            {
                numsHolder[i] = min + i;
            }

            for (int i = 0; i < diff; i++)//write a line, then rotate arr by 1
            {
                Console.WriteLine(string.Join("", numsHolder));
                LeftShiftArray<int>(numsHolder, 1);
            }

            Console.ReadKey();
        }
    }
}
