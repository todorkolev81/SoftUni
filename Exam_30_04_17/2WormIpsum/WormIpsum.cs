using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2WormIpsum
{
    class WormIpsum
    {
        static void Main()
        {
            var inputText = Console.ReadLine();
            var result = new List<string>();

            while (inputText != "Worm Ipsum")
            {
                var splited = inputText.Split(' ');

                foreach (var word in splited)
                {
                    int repeats = word.Length - word.ToCharArray().Distinct().Count();
                    //for (var i = 0; i < word.Length - 1; i++)
                    //{
                    //    if (word[i] == word[i])
                    //    {
                    //        word.Replace(word[i], (char)word.Length);
                    //    }
                    //}
                    if (repeats > 0)
                    {
                        var word2 = "";
                        word2 = word.Replace(word, new string('e',word.Length));
                        result.Add(word2);
                    }
                    result.Add(word);
                }
                inputText = Console.ReadLine();
            }


        }

    }
}

