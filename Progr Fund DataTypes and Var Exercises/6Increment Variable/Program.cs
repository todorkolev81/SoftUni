using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Increment_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int overflow = 0;

            if (n <= 256)
            {
                Console.WriteLine(n - 256);
                Console.WriteLine("Overflowed {0} times", overflow);
            }
            else
            {
                overflow = n / 256;
                Console.WriteLine(n - (overflow * 256));
                Console.WriteLine("Overflowed {0} times", overflow);
            }

            //Console.WriteLine(n % 256);
            //Console.WriteLine("Overflowed {0} times", n / 256);

        }

    }
}

