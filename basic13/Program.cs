using System;
using System.Collections.Generic;

namespace untracked_csharp
{
    class Program
    {
        public static void PrintNumbers()
        {
            for(int i = 1; i < 25; i++)
            {
                System.Console.WriteLine(i);
            }
        }
        public static int PrintNumbers2()
        {
            int sum = 0;
            for(int i = 1; i < 25; i++)
            {
                sum += i;
            }
                return sum;
        }

        public static void PrintOdds()
        {
            // Print all of the odd integers from 1 to 255.
            for(int i = 1; i < 256; i++)
            {
                if (i % 2 != 0)
                {
                System.Console.WriteLine(i);
                }
            }
        }

        public static void PrintSum()
        {
            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:
            
            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3

            PrintNumbers();
            int sum = PrintNumbers2();
            System.Console.WriteLine($"Sum: {sum}");
        }

        // Random Array
        // Create a function called RandomArray() that returns an integer array

        // Place 10 random integer values between 5-25 into the array
        // Print the min and max values of the array
        // Print the sum of all the values
        public static int[] RandomArray()
        {
            int[] numArray = new int[10];
            Random rand = new Random();
            int sum = 0;
            int min = numArray[0];
            System.Console.WriteLine($"Beginning minimum: {min}");
            int max = numArray[0];
            for(int val = 0; val < numArray.Length; val++)
            {
                numArray[val] = rand.Next(5,25);
                if (min > numArray[val])
                {
                    min = numArray[val];
                }
                if (max < numArray[val])
                {
                    max = numArray[val];
                }
                Console.WriteLine(numArray[val]);
                sum = sum + numArray[val];
            }

            System.Console.WriteLine($"Min: {min}, Max: {max}, Sum: {sum}");
            return numArray;
        }



    // Print all of the integers from 1 to 255
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();

            List<object> castEx = new List<object>();
            castEx.Add(7);
            castEx.Add(28);
            castEx.Add(-1);
            castEx.Add(true);
            castEx.Add("chair");

            int sum = 0;
            for (var idx = 0; idx < castEx.Count; idx++)
            {
                if (castEx[idx] is int)
                {
                    int num = (int)castEx[idx];
                    sum = sum + num;
                    // Console.WriteLine(castEx[idx]);
                }
            }
            // Console.WriteLine($"Sum: {sum}");

            RandomArray();
        }
    }
}
