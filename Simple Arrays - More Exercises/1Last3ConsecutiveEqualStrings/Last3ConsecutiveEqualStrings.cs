using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Last3ConsecutiveEqualStrings
{
    class Last3ConsecutiveEqualStrings
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ');

            int count = 1;

            for (int i = words.Length - 1; i > 0; i--)
            {
                if (words[i] == words[i - 1])
                {
                    count++;
                    if (count == 3)
                    {
                        Console.WriteLine("{0} {0} {0}", words[i]);
                        break;
                    }
                }
                else
                {
                    count = 1;
                }
            }
        }
    }
}

