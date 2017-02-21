using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3CamelsBack
{
    class CamelsBack
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var M = int.Parse(Console.ReadLine());

            var roundCount = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (M < numbers.Count)
                {
                    numbers.RemoveAt(0);
                    numbers.RemoveAt(numbers.Count - 1);
                    roundCount++;
                }

            }
            if (roundCount == 0)
            {
                Console.WriteLine("already stable: " + string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine($"{roundCount} rounds");
                Console.WriteLine("remaining: " + string.Join(" ", numbers));
            }

        }
    }
}
