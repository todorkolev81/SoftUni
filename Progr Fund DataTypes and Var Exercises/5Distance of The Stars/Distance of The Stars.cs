using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Distance_of_The_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            long ly = 9450000000000;
            var earthToStar = 4.22 * ly;
            decimal theCenterOfOurGalaxy = 26000 * ly;
            decimal milkyWay = 100000 * ly;
            decimal edgeUniverse = 46500000000M * ly;


            Console.WriteLine("{0:e2}", earthToStar);
            Console.WriteLine("{0:e2}", theCenterOfOurGalaxy);
            Console.WriteLine("{0:e2}", milkyWay);
            Console.WriteLine("{0:e2}", edgeUniverse);

        }
    }
}
