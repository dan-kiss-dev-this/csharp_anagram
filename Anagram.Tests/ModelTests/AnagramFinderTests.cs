using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System.Collections.Generic;
using System;

namespace Anagram.Tests
{
    [TestClass]

    public class AnagramTests
    {

        [TestMethod]
        public void AnagramConstructor_CreatesAnagramObject_AnagramFinder()
        {
            string userInput = "noon";
            AnagramFinder newAnagram = new AnagramFinder(userInput);
            Assert.AreEqual(typeof(AnagramFinder), newAnagram.GetType());
        }

        [TestMethod]
        public void AnagramConstructor_ChecksWord_String()
        {
            string userInput = "noon";
            AnagramFinder newAnagram = new AnagramFinder(userInput);
            string originalWord = newAnagram.MainWord;
            Assert.AreEqual(userInput, originalWord);
        }

        [TestMethod]
        public void CompareMaker_HoldsWordsToCheckForAnagrams_ListOfStrings()
        {
            string userInput = "noon";
            AnagramFinder newAnagram = new AnagramFinder(userInput);
            string compareWord1 = "nono";
            string compareWord2 = "ooon";
            // we want to add compare words   
            newAnagram.CompareMaker(compareWord1);
            newAnagram.CompareMaker(compareWord2);
            List<string> comparedWords = new List<string> { compareWord1, compareWord2 };
            List<string> returnedCompareWords = newAnagram.GetCompareWords();
            CollectionAssert.AreEqual(returnedCompareWords, comparedWords);
        }

        [TestMethod]

        public void CompareMaker_CheckLenghtOfWords_ListOfStrings()
        {
            string userInput = "noon";
            AnagramFinder newAnagram = new AnagramFinder(userInput);
            string compareWord1 = "nono";
            string compareWord2 = "ooon";
            string compareWord3 = "computer";
            string compareWord4 = "onon";
            newAnagram.CompareMaker(compareWord1);
            newAnagram.CompareMaker(compareWord2);
            newAnagram.CompareMaker(compareWord3);
            newAnagram.CompareMaker(compareWord4);
            List<string> comparedWords = new List<string> { compareWord1, compareWord2, compareWord4 };
            List<string> returnedComparedWords = newAnagram.GetCompareWords();
            CollectionAssert.AreEqual(returnedComparedWords, comparedWords);
        }

        public void SortString_WillSortStringsAToZ_String()
        {
            string userInput = "noon";
            string sortedSample = "nnoo";
            AnagramFinder newAnagram = new AnagramFinder(userInput);

            Assert.AreEqual(newAnagram.SortedMainWord, sortedSample);
        }
    }
}

// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()