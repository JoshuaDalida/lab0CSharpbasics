using System;
using System.IO;

namespace Lab_0_Basics_of_C_
{
    internal class Program
    {
        public static int InputLow()
        {
            Console.WriteLine("Please enter your low number: ");
            int low = int.Parse(Console.ReadLine());
            while (low < 0)
            {
                Console.WriteLine("Low number must be a positive number");
                Console.WriteLine("Please enter your low number:");
                low = int.Parse(Console.ReadLine());
            }
            return low;
        }

        public static int InputHigh(int low)
        {
            Console.WriteLine("Please enter your high number");
            int high = int.Parse(Console.ReadLine());
            while (high <= low)
            {
                Console.WriteLine("High number must be greater than low number.");
                Console.WriteLine("Please enter your high number ");
                high = int.Parse(Console.ReadLine());
            }
            return high;
        }

        public static void PrintArr(int[] arr)
        {
            foreach (int number in arr)
            {
                Console.Write(number + " ");
            }
        }

        public static bool IsPrime(int test)
        {
            if (test <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= test; i++)
            {
                if (test % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            // Task 1: Creating Variables and Task 2: Looping and Input Validation
            int low = InputLow();
            int high = InputHigh(low);
            int difference = high - low;
            Console.WriteLine("The difference is " + difference);

            // Task 3: Arrays and File I/O

            // Create an array of numbers between low and high
            int[] numbers = new int[difference - 1];
            int i = 0;
            while (high > low + 1)
            {
                numbers[i] = high - 1;
                i++;
                high = high - 1;
            }

            // Print every number in the array
            Console.WriteLine("Printing Numbers between low and high...");
            PrintArr(numbers);

            StreamWriter streamWriter = File.CreateText("data.txt");

            foreach (int number in numbers)
            {
                streamWriter.WriteLine(number);
            }
            i = low;
            foreach (int number in numbers)
            {
                if (IsPrime(number))
                {
                    Console.WriteLine(number + "is a prime number");
                }
            }

        }
    }
}
