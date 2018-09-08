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
            Console.WriteLine("Squared numbers that are even");
            for (int k = 0; k < randomListSquared.Count; k++)
            {
                if (randomListSquared[k] % 2 == 0)
                {
                    randomListSquaredEven.Add(randomListSquared[k]);
                    Console.Write(" " + randomListSquared[k]);
                }
            }

            Console.ReadLine();
        }
    }
}
