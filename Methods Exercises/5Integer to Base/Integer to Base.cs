using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Integer_to_Base
{
    class Integer_to_Base
    {
        static void Main(string[] args)
        {
            var number = long.Parse(Console.ReadLine());
            var baseSys = int.Parse(Console.ReadLine());

            var converted = IntegerToBase(number, baseSys);
            Console.WriteLine(converted);
        }
        static string IntegerToBase(long number, int baseSys)
        {
            var result = string.Empty;

            while (number > 0)
            {

                var remainder = number % baseSys;
                result = remainder + result;
                number /= baseSys;
            }
            return result;
        }

    }
}
