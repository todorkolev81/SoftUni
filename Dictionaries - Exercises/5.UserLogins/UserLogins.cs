using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.UserLogins
{
    class UserLogins
    {
        static void Main(string[] args)
        {
            var usernamePass = new SortedDictionary<string, string>();

            var input = Console.ReadLine();
            while (input != "login")
            {
                var tokens = input.Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var username = tokens[0];
                var pass = tokens[1];

                if (!usernamePass.ContainsKey(username))
                {
                    usernamePass[username] = pass;
                }
                usernamePass[username] = pass;

                input = Console.ReadLine();
            }
            var unsuccessfulLogins = 0;
            while (input != "end")
            {
                if (input == "login")
                {
                    input = Console.ReadLine();
                }

                var tokens = input.Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var username = tokens[0];
                var pass = tokens[1];

                if (usernamePass.ContainsKey(username))
                {
                    if (usernamePass.ContainsValue(pass))
                    {
                        Console.WriteLine($"{username}: logged in successfully");
                    }
                    else
                    {
                        Console.WriteLine($"{username}: login failed");
                        unsuccessfulLogins++;
                    }
                }

                else
                {
                    Console.WriteLine($"{username}: login failed");
                    unsuccessfulLogins++;
                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"unsuccessful login attempts: {unsuccessfulLogins}");
        }
    }
}

