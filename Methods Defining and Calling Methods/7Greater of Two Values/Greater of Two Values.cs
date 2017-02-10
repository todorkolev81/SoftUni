using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            
            switch (type)
            {
                case "int":
                    {
                        var value1 = int.Parse(Console.ReadLine());
                        var value2 = int.Parse(Console.ReadLine());
                        var bigger = GetMax(value1, value2);
                        Console.WriteLine(bigger);
                        break;
                    }
                case "char":
                    {
                        var value1 = char.Parse(Console.ReadLine());
                        var value2 = char.Parse(Console.ReadLine());
                        var bigger = GetMax(value1, value2);
                        Console.WriteLine(bigger);
                        break;
                    }
                case "string":
                    {
                        string value1 = Console.ReadLine();
                        string value2 = Console.ReadLine();
                        string bigger = GetMax(value1, value2);
                        Console.WriteLine(bigger);
                        break;
                    }
            }
        }
        static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            return num2;
        }
        static char GetMax(char char1, char char2)
        {
            int char1Int = char1;
            int char2Int = char2;
            return (char)GetMax(char1Int, char2Int);
        }
        static string GetMax(string string1, string string2)
        {
            if (string1.CompareTo(string2) >= 0)
            {
                return string1;
            }
            return string2;
        }
    }
}
