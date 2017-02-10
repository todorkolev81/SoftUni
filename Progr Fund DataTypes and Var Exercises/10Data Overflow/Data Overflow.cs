using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Data_Overflow
{
    class Data_Overflow
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var mybyte = 255;
            var myushort = 65535;
            var myuint = 429497295;
            var myulong = 18446744073709551615;
            
            //Console.WriteLine(n % 256);
            //Console.WriteLine("Overflowed {0} times", n / 256);
        }
    }
}
