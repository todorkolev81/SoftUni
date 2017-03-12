using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1AverageStudentGrades
{
    class AverageStudentGrades
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(' ');
                var name = tokens[0];
                var grade = double.Parse(tokens[1]);

                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<double>();
                }
                grades[name].Add(grade);
            }
            foreach (var nameAndGrades in grades)
            {
                Console.WriteLine("{0} -> {1} (avg: {2:f2})",
                    nameAndGrades.Key,
                    string.Join(" ", nameAndGrades.Value.Select(p => string.Format("{0:f2}", p))), // formula sprqmo p
                    nameAndGrades.Value.Average());
            }

        }
    }
}
