using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var k = inputNumbers.Length / 4;

            var firstRowLeft = inputNumbers.Take(k).Reverse().ToArray();
            var firstRowRight = inputNumbers.Reverse().Take(k).ToArray();
            var firstRow = firstRowLeft.Concat(firstRowRight).ToArray();
            var secondRow = inputNumbers.Skip(k).Take(2 * k).ToArray();

            //var sumRows = firstRow.Select((x, index) => x + secondRow[index]);
            //Console.WriteLine(string.Join(" ",sumRows));

            var sumRows = new int[firstRow.Length];
            for (int i = 0; i < firstRow.Length; i++)
            {
                sumRows[i] = firstRow[i] + secondRow[i];
            }
            Console.WriteLine(string.Join(" ", sumRows));
        }
    }
}
