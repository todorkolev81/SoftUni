using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ReverseArrayInPlace
{
    class ReverseArrayInPlace
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            //var result = numbers.Reverse();


            for (int i = 0; i < numbers.Length / 2; i++)
            {
                var leftIndex = i;
                var rightIndex = numbers.Length - 1 - i;

                var temp = numbers[leftIndex];
                numbers[leftIndex] = numbers[rightIndex];
                numbers[rightIndex] = temp;
            }

            Console.WriteLine(string.Join(" ", numbers));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(string.Join(" ", item));
            //}
        }
    }
}
