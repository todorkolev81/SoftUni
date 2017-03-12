using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3SortArrayStrings
{
    class SortArrayStrings
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
            .Split(' ')
            .ToArray();

          var  sortedInput = input
            .OrderBy(i => i);

            Console.WriteLine(string.Join(" ",sortedInput));

        }
    }
}
