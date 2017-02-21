using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1RemoveNegativesAndRev
{
    class RemoveNegativesAndRev
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var newList = new List<int>();
            //numbers.Sort();
            numbers.Reverse();
            foreach (var number in numbers)
            {
                if (number > 0)
                {
                    newList.Add(number);
                }
            }
            Console.WriteLine("empty");
            Console.WriteLine(string.Join(" ", newList));
        }

    }
}

