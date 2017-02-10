using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Min_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());

            GetMin(num1, num2, num3);

        }
        static void GetMin(int num1, int num2, int num3)
        {
            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine(num1);
            }
            else if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine(num2);
            }
            else if (num3 < num1 && num3 < num2)
            {
                Console.WriteLine(num3);
            }
        }
    }
}
