using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            var pattern = @"(\+\d{3}-\d{1}-\d{3}-\d{4})\b|(\+\d{3} \d{1} \d{3} \d{4})\b";
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
