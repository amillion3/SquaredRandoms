using System;
using System.Collections.Generic;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomList = new List<int>();
            var randomListSquared = new List<int>();
            var randy = new Random();

            Console.WriteLine("Original Random List:");
            for (int i = 0; i < 20; i++)
            {
                int val = randy.Next(1, 51);
                randomList.Add(val);
                Console.Write(" " + val);
            }

            Console.WriteLine("");
            Console.WriteLine("Squared List:");

            for (int j = 0; j < randomList.Count; j++ )
            {
                int temp = randomList[j];
                int squaredTemp = temp * temp;
                randomListSquared.Add(squaredTemp);
                Console.Write(" " + squaredTemp);
            }

            Console.WriteLine("");

            Console.ReadLine();
            // Using the Random class, generate a list of 20 random numbers that are in the range of 1-50.
            // Then remove any number that is odd from the list of squared numbers.

            //Random rnd = new Random();
            //for (int ctr = 1; ctr <= 15; ctr++)
            //{
            //    Console.Write("{0,3}    ", rnd.Next(-10, 11));
            //    if (ctr % 5 == 0) Console.WriteLine();
            //}
        }
    }
}
