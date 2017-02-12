using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Count_of_Neg_Elements_in_Array
{
    class CountNegElementsArray
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            var count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                var currentNumber = array[i];
                if (currentNumber < 0)
                {
                    count+= 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}
