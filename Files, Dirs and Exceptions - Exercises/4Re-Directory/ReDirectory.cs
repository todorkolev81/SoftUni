using System;
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
                var extension = fileInfo.Name.Split('.')[1];
                
            }

        }
    }
}
