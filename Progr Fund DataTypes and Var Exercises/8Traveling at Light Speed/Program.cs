using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Traveling_at_Light_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            double lyInput = double.Parse(Console.ReadLine());

            var oneLy = lyInput * 9450000000000;
            var speedOfLight = 300000;
            var timesec = oneLy / speedOfLight;

            var weeks = ((((timesec / 60) / 60) / 24) / 7);
            var days = (((timesec / 60) / 60) / 24) % 7;
            var hours = ((timesec / 60) / 60)  % 24;
            var min = (timesec / 60) % 60;
            var sec = timesec % 60;

            Console.WriteLine("{0} weeks", (int)weeks);
            Console.WriteLine("{0} days", (int)days);
            Console.WriteLine("{0} hours", (int)hours);
            Console.WriteLine("{0} minutes", (int)min);
            Console.WriteLine("{0} seconds", (int)sec);

        }
    }
}
