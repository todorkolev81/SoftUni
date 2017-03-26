using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4MergeFiles
{
    class MergeFiles
    {
        static void Main(string[] args)
        {
            var fileOne = File.ReadAllLines("FileOne.txt");
            var fileTwo = File.ReadAllLines("FileTwo.txt");

            var resultList = new List<string>();

            foreach (var item in fileOne)
            {
                resultList.Add(item);
            }
            foreach (var item in fileTwo)
            {
                resultList.Add(item);
            }
            resultList.Sort();
            File.WriteAllLines("output.txt", resultList);
        }
    }
}
