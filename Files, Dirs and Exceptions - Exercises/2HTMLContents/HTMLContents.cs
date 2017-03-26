using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2HTMLContents
{
    class HTMLContents
    {
        public static void Main(string[] args)
        {
            var lines = File.ReadAllLines("Input.txt");
            var title = string.Empty;
            var bodyPArts = new List<string>();

            foreach (var line in lines)
            {
                if (line=="exit")
                {
                    break;
                }
                var lineParts = line.Split(' ');

            }
        }
    }
}
