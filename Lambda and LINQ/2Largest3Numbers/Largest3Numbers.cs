using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList()
                .OrderByDescending(n => n)
                .Take(3);

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
