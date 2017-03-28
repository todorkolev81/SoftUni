using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine().Split(new[] { ',', ' ', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            var result = new List<string>();

            foreach (var word in inputText)
            {
                var pali = true;
                for (int i = 0; i < word.Length; i++)
                {
                    

                    if (word[i] != word[word.Length - i - 1])
                    {
                        pali = false;
                        break;
                    }
                }
                if (pali)
                {
                    result.Add(word);
                }
            }
           result = result.Distinct().OrderBy(x=>x).ToList();

            Console.WriteLine(string.Join(", ",result));
        }
    }
}
