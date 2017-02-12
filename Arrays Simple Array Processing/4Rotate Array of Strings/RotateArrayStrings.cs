using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Rotate_Array_of_Strings
{
    class RotateArrayStrings
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ');

            var result = new string[words.Length];
            result[0] = words[words.Length - 1];
            
            for (int i = 0; i < words.Length - 1; i++)
            {
                result[i + 1] = words[i];
            }
            var resultAsString = string.Join(" ", result);
            Console.WriteLine(resultAsString);
        }
    }
}
