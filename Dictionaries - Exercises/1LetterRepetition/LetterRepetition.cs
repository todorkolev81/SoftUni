using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1LetterRepetition
{
    class LetterRepetition
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var characters = new Dictionary<char, int>();

            foreach (var character in input)
            {
                if (!characters.ContainsKey(character))
                {
                    characters[character] = 1;
                }
                else
                {
                    characters[character]++;
                }
            }

            foreach (var item in characters)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
