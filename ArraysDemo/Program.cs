using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
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
        }
    }
}
