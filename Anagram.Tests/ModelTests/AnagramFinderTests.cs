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
            string userInput = "computer";
            AnagramFinder newAnagram = new AnagramFinder(userInput);
            Assert.AreEqual(typeof(AnagramFinder), newAnagram.GetType());
        }

        [TestMethod]
        public void AnagramConstructor_ChecksWord_String()
        {
            string userInput = "computer";
            AnagramFinder newAnagram = new AnagramFinder(userInput);
            string originalWord = newAnagram.MainWord;
            Assert.AreEqual(userInput, originalWord);
        }
    }
}

// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()