﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1FilterExtensions
{
    class FilterExtensions
    {
        static void Main(string[] args)
        {
            var inputExtension = Console.ReadLine();
            var files = Directory.GetFiles("input");

            var result = new List<string>();

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);

                if (fileInfo.Extension == "." + inputExtension)
                {
                    result.Add(fileInfo.Name);
                }
            }
            File.WriteAllLines("output.txt", result);
        }
    }
}
