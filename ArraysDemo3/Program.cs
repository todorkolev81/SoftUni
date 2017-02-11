using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 2 3 4 5 6 7
            var numbers = Console.ReadLine()
            .Split(' ')
             .Select(int.Parse)
             .ToArray();

            Console.WriteLine(numbers[0]);
        }
    }
}
