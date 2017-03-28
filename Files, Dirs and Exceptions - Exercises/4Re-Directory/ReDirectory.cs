﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Re_Directory
{
    class ReDirectory
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles("input");
            var extensions = new Dictionary<string, string>();

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);

                fileInfo.Name.Split('.');
                var extension = fileInfo.Extension.Trim('.');
                extensions.Add(fileInfo.Name, extension);
            }

            Directory.CreateDirectory("output");

            foreach (var kvp in extensions)
            {
                if (Directory.Exists($"output\\{kvp.Value}"))
                {
                    File.Move($"input\\{kvp.Key}", $"output\\{kvp.Value}\\{kvp.Key}");
                }
                else
                {
                    Directory.CreateDirectory($"output\\{kvp.Value}");
                    File.Move($"input\\{kvp.Key}", $"output\\{kvp.Value}\\{kvp.Key}");
                }
                
            }
        }

    }
}
