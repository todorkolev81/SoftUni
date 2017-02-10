using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Cypher_Roulette
{
    class Cypher_Roulette
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
        }
    }
}
