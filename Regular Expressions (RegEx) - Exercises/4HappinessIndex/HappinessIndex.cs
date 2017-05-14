using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _4HappinessIndex
{
    class HappinessIndex
    {
        static void Main(string[] args)
        {
            Regex happyPattern = new Regex(@"(\:\))|(\:D)|(\;\))|(\:\*)|(\:\])|(\;\])|(\:\})|(\;\})|(\(\:)|(\*\:)|(c\:)|(\[\:)|(\[\;)");
            Regex sadPattern = new Regex(@"([:D;)\]][(:[{c;])");

            string inputLine = Console.ReadLine();

            int happyCount = happyPattern.Matches(inputLine).Count;
            
            int sadCount = sadPattern.Matches(inputLine).Count;

           double happyIndex = happyCount / (double)sadCount;
            var status = "";
            if (happyIndex >= 2)
            {
                status = ":D";
            }
            else if (happyIndex > 1)
            {
                status = ":)";
            }
            else if (happyIndex == 1)
            {
                status = ":|";
            }
            else if (happyIndex < 1)
            {
                status = ":(";
            }

            Console.WriteLine("Happiness index: {0:f2} {1}", happyIndex, status);
            Console.WriteLine("[Happy count: {0}, Sad count: {1}]", happyCount, sadCount);
        }
    }
}
