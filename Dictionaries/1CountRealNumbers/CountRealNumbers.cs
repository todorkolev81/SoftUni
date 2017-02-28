using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var numbers = new SortedDictionary<double, int>();

            foreach (var num in input)
            {
                if (numbers.ContainsKey(num))
                {
                    numbers[num]++;
                }
                else
                {
                    numbers[num] = 1;
                }
            }
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
