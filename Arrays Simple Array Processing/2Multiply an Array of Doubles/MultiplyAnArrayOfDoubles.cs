using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Multiply_an_Array_of_Doubles
{
    class MultiplyAnArrayOfDoubles
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var p = double.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= p;
            }
            var result = string.Join(" ", numbers);
            Console.WriteLine(result);
        }
    }
}
