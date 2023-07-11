using System.Collections.Generic;

namespace Anagram.Models;

public class AnagramFinder
{
    public string MainWord { get; }
    public AnagramFinder(string userInput)
    {
        MainWord = userInput;
    }
}