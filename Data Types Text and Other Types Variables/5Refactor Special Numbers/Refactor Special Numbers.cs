using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxNumber = int.Parse(Console.ReadLine());
                   
            for (int i = 1; i <= maxNumber; i++)
            {
                var currentNumber = i;
                int sum = 0;
                while (currentNumber > 0)
                {
                    sum += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }
                var result = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {result}");
                
            }

        }
    }
}
