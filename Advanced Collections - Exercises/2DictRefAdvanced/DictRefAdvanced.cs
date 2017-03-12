using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DictRefAdvanced
{
    class DictRefAdvanced
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = new Dictionary<string, int>();

            while (input != "end")
            {
                var inputSplited = input.Split(new[] { '=', ' ', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
