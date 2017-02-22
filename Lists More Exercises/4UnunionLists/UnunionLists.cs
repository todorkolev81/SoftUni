using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4UnunionLists
{
    class UnunionLists
    {
        static void Main(string[] args)
        {
            var primalList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var newList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
                foreach (var item in newList)
                {
                    if (primalList.Contains(item))
                    {
                        primalList.Remove(item);
                    }
                    else
                    {
                        primalList.Add(item);
                    }
                }
            }
            primalList.Sort();
            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
