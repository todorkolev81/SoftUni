using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3EqualSumAfterExtraction
{
    class EqualSumAfterExtraction
    {
        static void Main(string[] args)
        {
            var firstList = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToList();
            var secondList = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToList();

            var sum1 = 0;
            var sum2 = 0;

            foreach (var number in firstList)
            {
                if (secondList.Contains(number))
                {
                    secondList.Remove(number);
                }
            }

            foreach (var number in firstList)
            {
                sum1 += number;
            }

            foreach (var number in secondList)
            {
                sum2 += number;
            }

            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes. Sum: {sum1}");
            }
            else
            {
                Console.WriteLine("No. Diff: {0}", Math.Abs(sum1 - sum2));
            }

        }
    }
}
