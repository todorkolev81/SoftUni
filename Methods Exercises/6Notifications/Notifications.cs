using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Notifications
{
    class Notifications
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var value1 = Console.ReadLine();
                switch (value1)
                {
                    case "success":
                        {
                            var input1 = Console.ReadLine();
                            var input2 = Console.ReadLine();
                            ShowSuccess(input1, input2);
                            break;
                        }
                    case "error":
                        {
                            var input1 = Console.ReadLine();
                            var input2 = int.Parse(Console.ReadLine());
                            ShowError(input1, input2);
                            break;
                        }
                }
            }
        }

        static void ShowSuccess(string operation, string message)
        {
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {message}.");
        }

        static void ShowError(string operation, int code)
        {
            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {code}.");
            if (code < 0)
            {
                Console.WriteLine($"Reason: Internal System Failure.");
            }
            else
            {
                Console.WriteLine($"Reason: Invalid Client Data.");

            }

        }


    }
}

