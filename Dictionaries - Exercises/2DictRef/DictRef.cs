using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DictRef
{
    class DictRef
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var result = new Dictionary<string, int>();

            while (input != "end")
            {
                var inputSplited = input.Split(new[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (!result.ContainsKey(inputSplited[0]))
                {
                    if (result.ContainsKey(inputSplited[1]))
                    {
                        var value = result[inputSplited[1]];
                        result.Add(inputSplited[0], value);
                    }
                    else
                    {
                        int n = 0;
                        if (int.TryParse(inputSplited[1], out n))
                        {
                            result.Add(inputSplited[0], int.Parse(inputSplited[1]));
                        }
                    }
                }
                else
                {

                    if (result.ContainsKey(inputSplited[1]))
                    {
                        var value = result[inputSplited[1]];
                        result[inputSplited[0]] = value;
                    }
                    else
                    {
                        int n = 0;
                        if (int.TryParse(inputSplited[1], out n))
                        {
                            result[inputSplited[0]] = int.Parse(inputSplited[1]);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} === {item.Value}");
            }
        }
    }
}
