using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2CitiesContinentCountry
{
    class CitiesContinentCountry
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var continentsData = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(' ');
                var continent = tokens[0];
                var country = tokens[1];
                var city = tokens[2];

                if (!continentsData.ContainsKey(continent))
                {
                    continentsData[continent] = new Dictionary<string, List<string>>();
                }

                if (!continentsData[continent].ContainsKey(country))
                {
                    continentsData[continent][country] = new List<string>();
                }
                continentsData[continent][country].Add(city);
            }
            foreach (var continentAndCountries in continentsData)
            {
                var continentName = continentAndCountries.Key;
                var countries = continentAndCountries.Value;

                Console.WriteLine($"{continentName}:");
                foreach (var countryAndCities in countries)
                {
                    var countryName = countryAndCities.Key;
                    var cities = countryAndCities.Value;
                    Console.WriteLine("  {0} -> {1}", countryName, string.Join(", ", cities));
                }
            }
        }
    }
}
