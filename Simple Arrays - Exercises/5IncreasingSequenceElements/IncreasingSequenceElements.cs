using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5IncreasingSequenceElements
{
    class IncreasingSequenceElements
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool areIncresing = true;
            int previous = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] <= previous)
                {
                    areIncresing = false;
                    break;
                }
                previous = numbers[i];
            }
            if (areIncresing)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
