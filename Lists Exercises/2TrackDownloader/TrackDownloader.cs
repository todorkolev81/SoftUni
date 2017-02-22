using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2TrackDownloader
{
    class TrackDownloader
    {
        static void Main(string[] args)
        {
            var blackList = Console.ReadLine()
                .Split();

            var newLine = Console.ReadLine();
            var whiteList = new List<string>();
            while (newLine != "end")
            {
                var isInBlackList = false;
                foreach (var blackListWord in blackList)
                {

                    if (newLine.Contains(blackListWord))
                    {
                        isInBlackList = true;
                        break;
                    }

                }
                if (!isInBlackList)
                {
                    whiteList.Add(newLine);
                }
                newLine = Console.ReadLine();
            }
            whiteList.Sort();

            foreach (var track in whiteList)
            {
                Console.WriteLine(track);
            }
        }
    }
}
