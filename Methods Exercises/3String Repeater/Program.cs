using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3String_Repeater
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());

            var result = RepeatString(str, count);
            Console.WriteLine(result);
        }

        static string RepeatString(string str, int count)
        {
            string repeteadString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                repeteadString += str;
            }
            return repeteadString;
        }
    }
}
