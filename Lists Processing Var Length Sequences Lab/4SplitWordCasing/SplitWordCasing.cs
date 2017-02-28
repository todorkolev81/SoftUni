using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4SplitWordCasing
{
    class SplitWordCasing
    {
        static void Main(string[] args)
        {

            char[] separators = { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
            var input = Console.ReadLine()
              .Split(separators)
              .ToList();

            var lower = new List<string>();
            var mixed = new List<string>();
            var upper = new List<string>();

           

            foreach (string word in input)
            {
                if (word.Equals(string.Empty))
                {
                    continue;
                }

                int lowerSum = 0;
                int upperSum = 0;

                foreach (char letter in word)
                {
                    if (letter >= 'a' && letter <= 'z')
                    {
                        lowerSum++;
                    }
                    else if (letter >= 'A' && letter <= 'Z')
                    {
                        upperSum++;
                    }
                    else
                    {
                        lowerSum = 1;
                        upperSum = 1;
                    }
                }
                if (lowerSum == 0)
                {
                    upper.Add(word);
                }
                else if (upperSum == 0)
                {
                    lower.Add(word);
                }
                else
                {
                    mixed.Add(word);
                }
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lower));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixed));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upper));
        }
    }
}
