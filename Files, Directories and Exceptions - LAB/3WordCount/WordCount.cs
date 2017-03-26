using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            var words = File.ReadAllText("words.txt").ToLower().Split();
            var text = File.ReadAllText("text.txt").ToLower().Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

            var wordCount = new Dictionary<string, int>();
            foreach (var word in words)
            {
                wordCount[word] = 0;
            }
            foreach (var word in text)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
            }

            File.WriteAllLines("output.txt", wordCount.OrderByDescending(kvp => kvp.Value).Select(kvp => $"{kvp.Key} - {kvp.Value}"));

        }
    }
}
