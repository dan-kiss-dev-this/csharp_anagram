using System;
using Anagram.Models;

namespace Anagram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Anagram Finder");
            Console.WriteLine("Please enter a main word:");
            string mainWord = Console.ReadLine();
            AnagramFinder newAnagramFinder = new AnagramFinder(mainWord);
            ComparisonWords(newAnagramFinder);
        }

        //function takes in comparison words
        static void ComparisonWords(AnagramFinder newAnagramFinder)
        {
            Console.WriteLine("Please enter a comparison word: ");
            string comparisonWord = Console.ReadLine();
            newAnagramFinder.CompareMaker(comparisonWord);
            Console.WriteLine("Would you like to add another word? Press 1 for yes, or press any other key no:");
            string userAnswer = Console.ReadLine();
            if (userAnswer == "1")
            {
                ComparisonWords(newAnagramFinder);
            }
            else
            {
                Comparison(newAnagramFinder);
            }
        }

        static void Comparison(AnagramFinder newAnagramFinder)
        {
            newAnagramFinder.SortWordList();
            Console.WriteLine("Here is the list of anagrams:");
            foreach (string userWord in newAnagramFinder.finalAnagram)
            {
                Console.WriteLine(userWord);
            }
            Console.WriteLine("-------");
            Main();
        }
    }
}
