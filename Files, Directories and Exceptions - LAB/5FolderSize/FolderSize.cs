using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5FolderSize
{
    class FolderSize
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles("TEstFolder");

            double sum = 0;
            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }
            sum = sum / 1024 / 1024;
            File.WriteAllText("output.txt", sum.ToString());
        }
    }
}
