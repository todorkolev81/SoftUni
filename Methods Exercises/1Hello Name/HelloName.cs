using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Hello_Name
{
    class HelloName
    {
        static void Main(string[] args)
        {
            var nameIn = Console.ReadLine();
            PrintHelloName(nameIn);
        }

        private static void PrintHelloName(string nameIn)
        {
            Console.WriteLine("Hello, {0}!",nameIn);
        }
    }
}
