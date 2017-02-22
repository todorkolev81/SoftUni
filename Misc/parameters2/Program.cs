using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameters2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintStudent("Pesho", 20, 3.5);
        }

        private static void PrintStudent(string name, int age, double grade)
        {
            Console.WriteLine($"{name} {age} {grade}");
        }
             
    }
}
