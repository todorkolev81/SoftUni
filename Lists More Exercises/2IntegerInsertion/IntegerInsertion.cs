using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2IntegerInsertion
{
    class IntegerInsertion
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .ToList();
                

            var newLine = Console.ReadLine();


            while (newLine != "end")
            {
                var firstDight = (int)Char.GetNumericValue(newLine[0]);
                numbers.Insert(firstDight, newLine);
                newLine = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
