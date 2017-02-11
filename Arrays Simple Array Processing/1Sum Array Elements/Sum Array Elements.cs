using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Sum_Array_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbers[i] = currentNumber;
            }

            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = numbers[i];
                sum += currentNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
