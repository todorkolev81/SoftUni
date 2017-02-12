using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6EqualSequenceElementsArray
{
    class EqualSequenceElementsArray
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool areEqual = true;
            int previous = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] != previous)
                {
                    areEqual = false;
                    break;
                }
                //previous = numbers[i];
            }
            if (areEqual)
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
