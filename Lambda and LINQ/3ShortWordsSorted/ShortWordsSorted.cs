using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                //.ToLower()
                .Split(". , : ; ( ) [ ] \" ' \\ / ! ? "
                .ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var sortedUniqueWords = words
                .Select(w => w.ToLower())
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .Distinct();

            Console.WriteLine(string.Join(", ", sortedUniqueWords));
        }
    }
}
