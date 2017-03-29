using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3UserDatabase2
{
    class UserDatabase2
    {
        private static string dbPath = "users.txt";
        private static Dictionary<string, string> users = new Dictionary<string, string>();
        private static string loggedInUser = null;

        public static void Main(string[] args)
        {
            if (!File.Exists(dbPath))
            {
                File.Create(dbPath).Close();
            }

            var dbLines = File.ReadAllLines(dbPath);
            foreach (var line in dbLines)
            {
                var lineParts = line.Split(' ');
                var Username = lineParts[0];
                var Pass = lineParts[1];

                users[Username] = Pass;
            }

            //File.ReadAllLines(dbPath)
            //    .Select(l =>
            //    {
            //        var parts = l.Split(' ');

            //        return new
            //        {
            //            Username = parts[0],
            //            Pass = parts[1]
            //        };
            //    });

            var commands = File.ReadAllLines("Input.txt");
            //var commands = Console.ReadLine();

            //while (commands != "exit")
            //{
            foreach (var command in commands)
            {
                var commandParts = command.Split(' ');

                switch (commandParts[0])
                {
                    case "register":
                        var username = commandParts[1];
                        var pass = commandParts[2];
                        var confirmPass = commandParts[3];
                        RegisterUser(username, pass, confirmPass);
                        break;
                    case "login":
                        username = commandParts[1];
                        pass = commandParts[2];
                        LoginUser(username, pass);
                        break;
                    case "logout":
                        Logout();
                        break;

                }
            }
            //commands = Console.ReadLine();
            //}
        }

        private static void Logout()
        {
            if (loggedInUser == null)
            {
                Console.WriteLine("There is no currently logged in user.");
                return;
            }
            loggedInUser = null;
        }

        private static void LoginUser(string username, string pass)
        {
            if (loggedInUser != null)
            {
                Console.WriteLine("There is already a logged in user.");
                return;
            }
            if (!users.ContainsKey(username))
            {
                Console.WriteLine("There is no user with the given username.");
                return;
            }
            if (users[username] != pass)
            {
                Console.WriteLine("The password you entered is incorrect.");
                return;
            }
            loggedInUser = username;
        }

        private static void RegisterUser(string username, string pass, string confirmPass)
        {
            if (users.ContainsKey(username))
            {
                Console.WriteLine("The given username already exists.");
                return;
            }
            if (pass != confirmPass)
            {
                Console.WriteLine("The two passwords must match.");
                return;
            }

            users[username] = pass;
            File.AppendAllLines(dbPath, new[] { $"{username} {pass}" });
        }
    }
}
