using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Draw_a_Filled_Square
{
    class Draw_a_Filled_Square
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            PrintHeaderAndFooterRow(n);
            for (int i = 0; i < n - 2; i++)
            {
                PrintMiddleRow(n);
            }
            PrintHeaderAndFooterRow(n);
        }

        static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }

        static void PrintHeaderAndFooterRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

    }
}
