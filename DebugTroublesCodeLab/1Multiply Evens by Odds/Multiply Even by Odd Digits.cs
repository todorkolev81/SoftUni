using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numInput = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvensAndOdds(numInput));
        }

        private static int GetMultipleOfEvensAndOdds(int num)
        {
            int sumEvens = GetSumOfEvenDigits(num);
            int sumOdds = GetSumOfOddDigits(num);
            return sumEvens * sumOdds;
        }

        private static int GetSumOfOddDigits(int NumOddDigits)
        {
            int sum = 0;
            NumOddDigits = Math.Abs(NumOddDigits);
            while (NumOddDigits > 0)
            {
                int lastDigit = NumOddDigits % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                NumOddDigits /= 10;
            }
            return sum;
        }
        private static int GetSumOfEvenDigits(int NumEvenDigits)
        {
            int sum = 0;
            NumEvenDigits = Math.Abs(NumEvenDigits);
            while (NumEvenDigits > 0)
            {
                int lastDigit = NumEvenDigits % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                NumEvenDigits /= 10;
            }
            return sum;
        }
    }
}
