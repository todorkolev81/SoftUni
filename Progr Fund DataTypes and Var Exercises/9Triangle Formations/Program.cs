using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Triangle_Formations
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            var triangleValidity1 = a + b > c;
            var triangleValidity2 = b + c > a;
            var triangleValidity3 = a + c > b;

            var isValid = triangleValidity1 && triangleValidity2 && triangleValidity3;
            if (isValid)
            {
                Console.WriteLine("Triangle is valid.");

                var rightTriangle1 = a * a + b * b == c * c;
                var rightTriangle2 = b * b + c * c == a * a;
                var rightTriangle3 = c * c + a * a == b * b;

                if (rightTriangle1)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else if (rightTriangle2)
                {
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }
                else if (rightTriangle3)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
                else
                {
                    Console.WriteLine("Triangle has no right angles");
                }
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
        }
    }
}
