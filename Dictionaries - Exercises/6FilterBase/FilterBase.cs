using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6FilterBase
{
    class FilterBase
    {
        static void Main(string[] args)
        {
            var nameAge = new Dictionary<string, int>();
            var nameSalary = new Dictionary<string, double>();
            var namePosition = new Dictionary<string, string>();


            var input = Console.ReadLine();
            while (input != "filter base")
            {
                var tokens = input.Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var ageOrSalaryOrPosition = tokens[1];

                int n = 0;
                double s = 0.0;

                if (int.TryParse(ageOrSalaryOrPosition, out n))
                {
                    nameAge.Add(name, int.Parse(ageOrSalaryOrPosition));
                }
                else if (double.TryParse(ageOrSalaryOrPosition, out s))
                {
                    nameSalary.Add(name, double.Parse(ageOrSalaryOrPosition));
                }
                else
                {
                    namePosition.Add(name, ageOrSalaryOrPosition);
                }
                input = Console.ReadLine();
            }
            if (input == "filter base")
            {
                input = Console.ReadLine();
                if (input == "Position")
                {
                    foreach (var pair in namePosition)
                    {
                        Console.WriteLine($"Name: {pair.Key}");
                        Console.WriteLine($"Position: {pair.Value}");
                        Console.WriteLine("====================");
                    }
                }
                else if (input == "Salary")
                {

                    foreach (var pair in nameSalary)
                    {
                        Console.WriteLine($"Name: {pair.Key}");
                        Console.WriteLine($"Salary: {pair.Value:f2}");
                        Console.WriteLine("====================");
                    }
                }
                else if (input == "Age")
                {
                    foreach (var pair in nameAge)
                    {
                        Console.WriteLine($"Name: {pair.Key}");
                        Console.WriteLine($"Age: {pair.Value}");
                        Console.WriteLine("====================");
                    }
                }
            }
        }
    }
}


