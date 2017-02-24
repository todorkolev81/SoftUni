using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5CharRotation
{
    class CharRotation
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var result = "";
            for (int i = 0; i < inputString.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result += (char)(inputString[i] - numbers[i]);
                }
                else
                {
                    result += (char)(inputString[i] + numbers[i]);
                }
            }
            Console.WriteLine(result);
        }
    }
}
