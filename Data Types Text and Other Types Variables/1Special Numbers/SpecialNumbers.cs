namespace _1Special_Numbers
{
    using System;
    public class SpecialNumbers
    {
        public static void Main()
        {
            //var result = "123456";
            //foreach (var symbol in result)
            //{
            //    Console.WriteLine(symbol);
            //}
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var currentNumber = i;
                var sum = 0;

                foreach (var symbol in currentNumber.ToString())
                {

                    var digit = symbol - '0';
                    sum += digit;
                }
                //if (sum == 5 || sum == 7 || sum == 11)
                //{
                //    Console.WriteLine($"{i} -> True");
                //}
                //else
                //{
                //    Console.WriteLine($"{i} -> False");
                //}
                var result = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {result}");
            }
        }
    }
}

