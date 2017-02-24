using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3SumAdjacentEqualNumbrs
{
    class SumAdjacentEqualNumbrs
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < input.Count - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    input[i] = input[i] + input[i + 1];
                    input.Remove(input[i + 1]);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
