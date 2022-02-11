using System;

namespace ObjectOrientedProgram
{
    class Program
    {
        static int[] GenerateNumbers()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            return array;
        }


        static void Reverse(ref int[] array)
        {
            int start = 0;
            int end = array.Length - 1;
            while(start < end)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }
        }



        static void PrintNumbers(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
        }


        static int Fibonacci(int val)
        {
            if(val == 0)
            {
                return 0;
            }
            else if(val == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(val - 2) + Fibonacci(val - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1/");
            int[] numbers = GenerateNumbers();
            Reverse(ref numbers);
            PrintNumbers(numbers);

            Console.WriteLine();
            Console.WriteLine("2/");
            Console.WriteLine($"Fibonacci is: {Fibonacci(8)}");
        }
    }
}
