using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Count_of_Given_Elem_in_Array
{
    class CountGivenElemArray
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var n = int.Parse(Console.ReadLine());

            var count = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = numbers[i];

                if (currentNumber == n)
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}
