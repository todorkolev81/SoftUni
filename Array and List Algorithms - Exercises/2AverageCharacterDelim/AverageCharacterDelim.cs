using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2AverageCharacterDelim
{
    class AverageCharacterDelim
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .ToArray();

            var sumOfChar = 0;
            var count = 0;
            foreach (var word in input)
            {
                foreach (var item in word)
                {
                    sumOfChar += item;
                    count++;
                }
            }
            var delimiter = (char)(sumOfChar / count);
            string upperDel = Convert.ToChar(delimiter).ToString();
            string upper = upperDel.ToUpper();

            Console.WriteLine(string.Join($"{upper}", input));
        }
    }
}
