using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2FishStatistics
{
    class FishStatistics
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var pattern = @"(>*<*\(*'>?)|(>*<*\(*->?)|(>*<*\(*x>?)";

            Regex regex = new Regex(pattern);

            MatchCollection validFish = regex.Matches(input);

            var list = new List<string>();

            foreach (Match fish in validFish)
            {
                //var check = 0;

                //if (int.TryParse(card.Groups[2].Value, out check))
                //{
                //    if (check < 2 || check > 10)
                //    {
                //        continue;
                //    }
                //}
                list.Add(fish.Value);
            }
        }
    }
}
