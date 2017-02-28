using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var squares = new List<int>();
            foreach (var num in input)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    squares.Add(num);
                }
            }
            squares.Sort();
            squares.Reverse();

            Console.WriteLine(string.Join(" ", squares));

        }
    }
}
