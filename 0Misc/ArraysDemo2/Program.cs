using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days =
            {
                "Mon","Tue","Wed","Thu",
                "Fri"
            };
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }
        }
    }
}
