using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
