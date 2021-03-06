﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4ArrayHistogram
{
    class ArrayHistogram
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
             .Split(' ')
             .ToArray();

            var foundWords = new List<string>();
            var wordCount = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];

                if (foundWords.Contains(currentWord))
                {
                    int wordIndex = foundWords.IndexOf(currentWord);
                    wordCount[wordIndex]++;
                }
                else
                {
                    foundWords.Add(currentWord);
                    wordCount.Add(1);
                }
            }

            bool hasSwapped = true;
            while (hasSwapped)
            {
                hasSwapped = false;
                for (int i = 0; i < wordCount.Count-1; i++)
                {
                    if (wordCount[i] < wordCount[i + 1])
                    {
                        int temp = wordCount[i];
                        wordCount[i] = wordCount[i + 1];
                        wordCount[i + 1] = temp;

                        string tempWord = foundWords[i];
                        foundWords[i] = foundWords[i + 1];
                        foundWords[i + 1] = tempWord;

                        hasSwapped = true;
                    }
                }
            }

            for (int i = 0; i < foundWords.Count; i++)
            {
                var currentPercentage = (wordCount[i] * 100.0) / words.Length;
                Console.WriteLine("{0} -> {1} times ({2:F2}%)", foundWords[i], wordCount[i], currentPercentage);
            }
        }
    }
}
