using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4FlipListSides
{
    class FlipListSides
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToList();
            var result = new List<int>();

            for (int i = 1; i < input.Count-1; i++)
            {
                
                if (i != 0 || i != input.Count)
                {
                    result.Add(input[i]);
                }
                
            }
            result.Reverse();

            Console.WriteLine(input[0]+" " + string.Join(" ", result)+" "+input[input.Count-1]);
        }
    }
}
