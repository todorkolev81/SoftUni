using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToArray();

            var random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var randomPosition = random.Next(0, words.Length);

                var temp = words[i];
                words[i] = words[randomPosition];
                words[randomPosition] = temp;
            }
            Console.WriteLine(string.Join("\r\n", words));

        }
    }
}
