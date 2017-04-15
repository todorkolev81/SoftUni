using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1MatchFullName
{
    class MatchFullName
    {
        static void Main()
        {
            
            var pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            var regex = new Regex(pattern);

            var text = Console.ReadLine();

            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
