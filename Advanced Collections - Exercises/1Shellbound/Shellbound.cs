using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Shellbound
{
    class Shellbound
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = new Dictionary<string, HashSet<int>>();

            while (input != "Aggregate")
            {
                var inputSplited = input
                    .Split().ToArray();
                var region = inputSplited[0];
                var shellSize = int.Parse(inputSplited[1]);

                if (!result.ContainsKey(region))
                {
                    result[region] = new HashSet<int>();
                }
                result[region].Add(shellSize);
                input = Console.ReadLine();
            }
            foreach (var regionAndSize in result)
            {
                var regionName = regionAndSize.Key;
                var sizeOfShell = regionAndSize.Value;
                var sum = 0;
                foreach (var item in regionAndSize.Value)
                {
                    sum += item;
                }
                Console.WriteLine("{0} -> {1} ({2})",
                  regionName, string.Join(", ", sizeOfShell), sum - (sum / regionAndSize.Value.Count));
            }
        }
    }
}

