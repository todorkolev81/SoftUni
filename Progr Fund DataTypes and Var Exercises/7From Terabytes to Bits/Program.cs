using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7From_Terabytes_to_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            double tera = double.Parse(Console.ReadLine());

            var bits = tera * 8796093022208;

            Console.WriteLine(bits);
        }
    }
}
