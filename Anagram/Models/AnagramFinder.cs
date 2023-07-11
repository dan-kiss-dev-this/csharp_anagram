using System.Collections.Generic;

namespace Anagram.Models;

public class AnagramFinder
{
    public string MainWord { get; }
    private List<string> compareWords = new List<string> { };
    public AnagramFinder(string userInput)
    {
        MainWord = userInput;
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

}