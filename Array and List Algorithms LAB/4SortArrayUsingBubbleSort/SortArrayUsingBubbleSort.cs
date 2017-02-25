using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4SortArrayUsingBubbleSort
{
    class SortArrayUsingBubbleSort
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool swapped = false;

            do
            {
                swapped = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    var current = numbers[i];
                    var next = numbers[i + 1];

                    if (current > next)
                    {
                        numbers[i + 1] = current;
                        numbers[i] = next;
                        swapped = true;
                    }
                }
            }
            while (swapped);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
