using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            var result = string.Join(Environment.NewLine, arr);
            Console.WriteLine(result);

            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
        }
    }
}
