using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Wormtest
{
    class Wormtest
    {
        static void Main(string[] args)
        {
            int lengthWormM = int.Parse(Console.ReadLine());
            double widthWormCm = double.Parse(Console.ReadLine());

            var lengthCm = lengthWormM * 100;
            var check = lengthCm % widthWormCm;
            var result = 0.00;
            if (check == 0)
            {
                result = lengthCm * widthWormCm;
                Console.WriteLine("{0:f2}", result);
            }
            else
            {
                result = Math.Round((lengthCm / widthWormCm) * 100, 2);
                Console.WriteLine("{0:f2}%", result);
            }
        }
    }
}
