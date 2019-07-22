﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string document= File.ReadAllText("mobydick.txt");
            while (PromptForSearchWord(out string searchWord))
                CountWord(document,searchWord);
            
        }

        static void CountWord(string document,string searchWord)
        {
            int count = 0;
            int ndx = document.IndexOf(searchWord);
            while(ndx >= 0)
            {
                count++;
                ndx = document.IndexOf(searchWord, ndx + searchWord.Length);
            }
            Console.WriteLine($"The word {searchWord} was found {count} times.");
        }

        static bool PromptForSearchWord(out string searchWord) // Please enter a word to searh for
        {
            Console.Write("Please enter a word to search for: ");
            searchWord = Console.ReadLine(); // the out parameter is a promise to provide a searcWord
            return !string.IsNullOrWhiteSpace(searchWord);

     
        }
    }
}
