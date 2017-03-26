using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DefaultValues
{
    class DefaultValues
    {
        static void Main(string[] args)
        {
            var defaultValues = new Dictionary<string, string>();

            var input = Console.ReadLine();
            while (input != "end")
            {
                var tokens = input.Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var key = tokens[0];
                var value = tokens[1];

                defaultValues[key]=value;

                input = Console.ReadLine();
            }
            var input2 = Console.ReadLine();

            defaultValues
              .Where(x => x.Value != "null")
              .OrderByDescending(x => x.Value.Length)
              .ToList()
              .ForEach(x => Console.WriteLine($"{x.Key} <-> {x.Value}"));


            defaultValues
                .Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => input2)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Key} <-> {x.Value}"));

        }

    }
}

