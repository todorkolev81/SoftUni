using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var count = new int[input.Max() + 1];

            foreach (var number in input)
            {
                count[number]++;
            }
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine($"{i} -> {count[i]}");
                }
            }

            ///

            //input.Sort();
            //input.Add(int.MaxValue);

            //var counter = 1;

            //for (int i = 0; i < input.Count - 1; i++)
            //{
            //    var currentNum = input[i];
            //    var nextNum = input[i + 1];

            //    if (currentNum == nextNum)
            //    {
            //        counter++;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{currentNum} -> {counter}");
            //        counter = 1;
            //    }
            //}
        }
    }
}
