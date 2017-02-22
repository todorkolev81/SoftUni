using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1RemoveElementsOddPositions
{
    class RemoveElementsOddPositions
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .ToList();

            var result = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                if (i%2==1)
                {
                    result.Add(input[i]);
                }
            }
            Console.WriteLine(string.Join(string.Empty,result));

        }
    }
}
