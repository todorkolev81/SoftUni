using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            input.Sort();

            Console.WriteLine(string.Join(" <= ", input));
        }
    }
}
