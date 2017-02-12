using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ');
            var names = Console.ReadLine().Split(' ');
            var inputNames = Console.ReadLine();

            while (inputNames != "done")
            {
                PrintNumbersAndNames(numbers, names, inputNames);

                inputNames = Console.ReadLine();
            }
        }

        private static void PrintNumbersAndNames(string[] numbers, string[] names, string inputNames)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (inputNames == names[i])
                {
                    Console.WriteLine("{0} -> {1}", inputNames, numbers[i]);
                    break;
                }
            }
        }
    }
}

