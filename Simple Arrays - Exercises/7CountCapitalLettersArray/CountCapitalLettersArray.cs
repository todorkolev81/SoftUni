using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7CountCapitalLettersArray
{
    class CountCapitalLettersArray
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var words = text.Split();

            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
             if (words[i].Length == 1 && words[i] == words[i].ToUpper())
               //  if (words[i].Length == 1 && words[i][0] >= 'A' && words[i][0] <= 'Z')
                {
                    count++;
                }
            }

            Console.WriteLine(count);

        }
    }
}
