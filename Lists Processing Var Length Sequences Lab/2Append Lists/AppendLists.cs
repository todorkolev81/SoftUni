using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Append_Lists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split('|')
                //.Select(int.Parse)
                .ToList();

            input.Reverse();

            var result = new List<string>();

            foreach (var item in input)
            {
                result.Add(item);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
