using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1RegisteredUsers
{
    class RegisteredUsers
    {
        static void Main(string[] args)
        {
            var userNameDate = new Dictionary<string, DateTime>();

            var input = Console.ReadLine();
            while (input != "end")
            {
                var tokens = input.Split(" -> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var userName = tokens[0];
                var dates = DateTime.ParseExact(tokens[1], "dd/mm/yyyy", CultureInfo.InvariantCulture);

                userNameDate.Add(userName, dates);

                input = Console.ReadLine();

                //if (userNameDate.ContainsValue(dates))
                //{
                //    userNameDate.Remove(userName);
                //}

            }
            userNameDate
                .Reverse()
                .OrderBy(uND => uND.Value)
                .Take(5)
                .OrderByDescending(uND => uND.Value)
                .ToList()
                .ForEach(uND => Console.WriteLine($"{uND.Key}"));
            //.ToDictionary(
            //    uND => uND.Key,
            //    uND => uND.Value);


            //foreach (var name in sortedUserNameDate)
            //{
            //    Console.WriteLine($"{name.Key} {name.Value}");
            //}
        }

    }
}
