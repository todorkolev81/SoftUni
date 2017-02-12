using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ArrayElementsEqualTheirIndex
{
    class ArrayElementsEqualTheirIndex
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var result = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == i)
                {
                    result = i + " ";
                }
            }
            Console.WriteLine(result+);
        }
    }
}
