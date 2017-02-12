using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CountOccursLargerNumbersArray
{
    class CountOccursLargerNumbersArray
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var n = double.Parse(Console.ReadLine());
            var count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = numbers[i];

                if (currentNumber > n)
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}
