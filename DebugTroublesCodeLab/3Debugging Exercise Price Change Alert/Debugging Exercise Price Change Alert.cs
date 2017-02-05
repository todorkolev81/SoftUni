using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Debugging_Exercise_Price_Change_Alert
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double procentInput = double.Parse(Console.ReadLine());
            double lastNum = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double number = double.Parse(Console.ReadLine());
                double divieded = ResultFromDevidingTheNumbers(lastNum, number);
                bool isSignificantDifference = Difference(divieded, procentInput);
                string message = GetTheFinalText(number, lastNum, divieded, isSignificantDifference);
                Console.WriteLine(message);

                lastNum = number;
            }
        }

        private static string GetTheFinalText(double currNum, double currLastNum, double difference, bool trueOrFalse)

        {
            string printText = "";
            if (difference == 0)
            {
                printText = string.Format("NO CHANGE: {0}", currNum);
            }
            else if (!trueOrFalse)
            {
                printText = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", currLastNum, currNum, difference * 100);
            }
            else if (trueOrFalse && (difference > 0))
            {
                printText = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", currLastNum, currNum, difference*100);
            }
            else if (trueOrFalse && (difference < 0))
                printText = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", currLastNum, currNum, difference*100);
            return printText;
        }
        private static bool Difference(double devidedTo, double difference)
        {
            if (Math.Abs(devidedTo) >= difference)
            {
                return true;
            }
            return false;
        }

        private static double ResultFromDevidingTheNumbers(double currCurr, double currLast)
        {
            double resultFromDeviding = (currLast - currCurr) / currCurr;
            return resultFromDeviding;

        }
    }
}
