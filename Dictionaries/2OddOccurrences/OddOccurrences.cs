using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2OddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!counts.ContainsKey(word))
                {
                    counts[word] = 0;
                }
                else
                {
                    counts[word]++;
                }
            }
            var results = new List<string>();

            foreach (var pair in counts)
            {
                if (pair.Value % 2 == 0)
                {
                    results.Add(pair.Key);
                }
            }
            Console.WriteLine(string.Join(", ", results));
        }
    }
}
