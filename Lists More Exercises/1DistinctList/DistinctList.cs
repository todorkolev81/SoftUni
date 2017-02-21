using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DistinctList
{
    class DistinctList
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var resultList = new List<int>();

            foreach (var number in numbers)
            {
                if (!resultList.Contains(number))
                {
                    resultList.Add(number);
                }
            }

            //for (int i = 0; i < numbers.Count; i++)
            //{

            //    if (!resultList.Contains(numbers[i]))
            //    {
            //        resultList.Add(numbers[i]);
            //    }
            //}
            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}

