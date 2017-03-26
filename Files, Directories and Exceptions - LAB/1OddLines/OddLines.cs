using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllLines("../../input.txt");
            for (int i = 1; i < text.Length; i+=2)
            {
                File.AppendAllText("../../output.txt", text[i] + "\r\n");
            }
        }
    }
}
