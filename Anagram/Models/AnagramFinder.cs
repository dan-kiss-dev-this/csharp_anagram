using System.Collections.Generic;
using System.Linq;
using System;

namespace Anagram.Models;

public class AnagramFinder
{
    public string MainWord { get; }

    public string SortedMainWord { get; set; }

    private List<string> compareWords = new List<string> { };
    public AnagramFinder(string userInput)
    {
        MainWord = userInput;
        SortedMainWord = SortString(MainWord);
    }

    public void CompareMaker(string newWord)
    {
        if (MainWord.Length == newWord.Length)
        {
            compareWords.Add(newWord);
        }
    }

    public List<string> GetCompareWords()
    {
        return compareWords;
    }

    public string SortString(string someString)
    {
        return String.Concat(someString.OrderBy(c => c));
    }

    // add business logic to compare MainWord to compareWords

}