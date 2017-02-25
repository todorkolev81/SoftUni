using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ArrayContainsElement
{
    class ArrayContainsElement
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var numberToFind = int.Parse(Console.ReadLine());

            bool found = numbers.Contains(numberToFind);
            if (found)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

            //var found = false;
            //foreach (var number in numbers)
            //{
            //    if (number == numberToFind)
            //    {
            //        found = true;
            //        Console.WriteLine("yes");
            //        break;
            //    }
            //}
            //if (!found)
            //{
            //    Console.WriteLine("no");
            //}
        }
    }
}
