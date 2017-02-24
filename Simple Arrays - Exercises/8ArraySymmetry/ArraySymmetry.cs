using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8ArraySymmetry
{
    class ArraySymmetry
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            bool issymetric = true;

            for (int i = 0; i < input.Length/2; i++)
            {
                var firstWord = input[i];
                var secondWord = input[input.Length - 1 - i];

                if (firstWord!=secondWord)
                {
                    issymetric = false;
                    break;
                }
            }
            if (issymetric)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
