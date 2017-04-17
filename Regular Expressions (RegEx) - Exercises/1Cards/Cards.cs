using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1Cards
{
    class Cards
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var pattern = @"([2-9JQKA]{1}[SHDC])|(\d[0-9JQKA])[SHDC]";

            Regex regex = new Regex(pattern);

            MatchCollection matchedCard = regex.Matches(input);

            var list = new List<string>();

            foreach (Match card in matchedCard)
            {
                var check = 0;

                if (int.TryParse(card.Groups[2].Value, out check))
                {
                    if (check < 2 || check > 10)
                    {
                        continue;
                    }
                }
                list.Add(card.Value);
            }

            Console.WriteLine(string.Join(", ", list));

        }
    }
}
