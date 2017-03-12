using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3MixedPhones
{
    class MixedPhones
    {
        static void Main(string[] args)
        {
            var phoneNumbers = new SortedDictionary<string, long>();

            var line = Console.ReadLine();
            while (line != "Over")
            {
                var tokens = line.Split(" :".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                var firstElemenet = tokens[0];
                var secondElement = tokens[1];

                long phoneNumber = 0;
                if (long.TryParse(firstElemenet, out phoneNumber))
                {
                    phoneNumbers[secondElement] = phoneNumber;
                }
                else if (long.TryParse(secondElement, out phoneNumber))
                {
                    phoneNumbers[firstElemenet] = phoneNumber;
                }
                line = Console.ReadLine();
            }
            foreach (var nameNumberPair in phoneNumbers)
            {
                var name = nameNumberPair.Key;
                var phoneNumber = nameNumberPair.Value;

                Console.WriteLine($"{name} -> {phoneNumber}");
            }
        }
    }
}
