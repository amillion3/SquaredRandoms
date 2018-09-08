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
            var randomListSquaredEven = new List<int>();
            int numberOfRandomNumbers = 20;
            var randy = new Random();

            for (int i = 0; i < numberOfRandomNumbers; i++)
            {
                // Generate a random int between 1 and 50
                int val = randy.Next(1, 51);
                randomList.Add(val);

                // Square the random integers
                int valSquared = val * val;
                randomListSquared.Add(valSquared);

                // Check even/odd and save only the even values
                if (valSquared % 2 == 0)
                {
                    randomListSquaredEven.Add(valSquared);
                }
            }
            Console.ReadLine();
        }
    }
}
