using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10

            var oneThruTen = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int t in oneThruTen)
            {
                Console.WriteLine(t);
            }

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            List<int> evens = new List<int>();

            
            /*
            foreach (int even in evens)
            {
                Console.WriteLine(even);
            }*/

            var odds = new List<int>();

            



            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            for (int i = 1; i <= 1000; i++)
            {
                if (i%2==0)
                {
                    evens.Add(i);
                }
                else
                {
                    odds.Add(i);
                }
            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            
            foreach (int even in evens)
            {
                Console.WriteLine($"The number {even} is even.");
            }

            
            foreach (int odd in odds)
            {
                Console.WriteLine($"The number {odd} is odd.");
            }
        }
    }
}
