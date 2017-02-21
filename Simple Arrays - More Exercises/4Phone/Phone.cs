using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Phone
{
    class Phone
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ');
            var names = Console.ReadLine().Split(' ');
            var inputFunctionAndNames = Console.ReadLine().Split(' ');

            while (inputFunctionAndNames[0] != "done")
            {
                FunctionCall(numbers, names, inputFunctionAndNames);
                inputFunctionAndNames = Console.ReadLine().Split(' ');
            }
        }


        static void FunctionCall(string[] numbers, string[] names, string[] inputFunctionAndNames)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (inputFunctionAndNames[1] == numbers[i] || inputFunctionAndNames[1] == names[i])
                {
                    SumOfString(numbers, inputFunctionAndNames, names);
                }
            }
        }
        static void SumOfString(string[] numbers, string[] inputFunctionAndNames, string[] names)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (inputFunctionAndNames[1] == numbers[i] || inputFunctionAndNames[1] == names[i])
                {
                    var sum = 0;
                    for (int n = 0; n < numbers[i].Length; n++)
                    {
                        numbers[i] = names[i];
                        var sumOfDigits = numbers[n].ToCharArray();
                        foreach (var character in sumOfDigits)
                        {
                            if (character > 48 && character <= 57)
                            {
                                sum += character - '0';
                            }
                        }
                    
                        if (sum % 2 != 0)
                        {
                            Console.WriteLine($"calling {numbers[n]}");
                            Console.WriteLine("no answer");
                            break;
                        }
                        else if (sum % 2 == 0)
                        {
                            Console.WriteLine("call ended. duration: " + (sum / 60) + ":" + (sum % 60));
                            break;
                        }
                    }
                }
            }
        }
    }
}







