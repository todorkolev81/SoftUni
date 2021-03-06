﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Largest_Element_in_Array
{
    class LargestElementInArray
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var array = new int[n];


            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            var maxNumberSoFar = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                var currentNumber = array[i];
                if (currentNumber > maxNumberSoFar)
                {
                    maxNumberSoFar = currentNumber;
                }
            }
            Console.WriteLine(maxNumberSoFar);
        }
    }
}
