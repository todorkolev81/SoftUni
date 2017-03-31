using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3FlattenDictionary
{
    class FlattenDictionary
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, Dictionary<string, string>>();

            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var inputParams = inputLine.Split(' ');

                if (inputParams[0] != "flatten")
                {
                    var key = inputParams[0];
                    var innerKey = inputParams[1];
                    var innerValue = inputParams[2];

                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary.Add(key, new Dictionary<string, string>());
                    }

                    dictionary[key][innerKey] = innerValue;

                }
                else
                {
                    var key = inputParams[1];
                    dictionary[key] = dictionary[key]
                        .ToDictionary(x => x.Key + x.Value, x => "flattened");

                }
                inputLine = Console.ReadLine();
            }
            var orderedDictionary = dictionary
                .OrderByDescending(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var entry in orderedDictionary)
            {
                Console.WriteLine("{0}", entry.Key);

                var orderedInnerDictionary = 
                    entry.Value
                    .Where(x=>x.Value!="flattened")
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                var flattenedValues = entry.Value
                    .Where(x => x.Value == "flattened")
                    .ToDictionary(x => x.Key, x => x.Value);

                var count = 1;
                foreach (var innerEntry in orderedInnerDictionary)
                {
                    Console.WriteLine("{0}. {1} - {2}",count, innerEntry.Key, innerEntry.Value);
                    count++;
                }
                foreach (var flattenedEntry in flattenedValues)
                {
                    Console.WriteLine("{0}. {1}",count, flattenedEntry.Key);
                    count++;
                }
            }

        }
    }
}
