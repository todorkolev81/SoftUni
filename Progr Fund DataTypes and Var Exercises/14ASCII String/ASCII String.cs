using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14ASCII_String
{
    class ASCII_String
    {
        static void Main(string[] args)
        {
            var numberOfStrings = int.Parse(Console.ReadLine());
            var result = string.Empty;
            var currentString = string.Empty;

            for (int i = 1; i <= numberOfStrings; i++)
            {

                currentString += (char)int.Parse(Console.ReadLine());

            }
            result += currentString;

            Console.WriteLine(result);
        }
    }
}
