using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System.Collections.Generic;
using System;

namespace WordCounter.Test
{
  [TestClass]
  public class WordCounterTests : IDisposable
  {
    public void Dispose()
    {
      //WordCounter.ClearAll();
    }
    [TestMethod]
    public void WordConstructor_CreatesInstance_ReturnsString()
    {
      Word testWord = new Word("cat", "Hello cat");
      Assert.AreEqual(typeof(Word), testWord.GetType());
    }
    [TestMethod]
    public void CheckWord_ChecksForDigitInWord_ReturnsTrue()
    {
      Word testWord = new Word("cat1", "Hello cat");
      Assert.AreEqual(true, testWord.CheckWord(testWord.Input));
    }

    [TestMethod]
    public void SplitSentence_SplitsEveryWordIntoArray_ReturnsWords()
    {
      Word testSentence = new Word("cat", "welcome cat to the world");
      Assert.AreEqual("welcome cat to the world", testSentence.SplitSentence(testSentence.Sentence));
    }
    [TestMethod]
    public void WordCount_CountsTotalNumberWordsInASentence_ReturnsInt()
    {
      Word count = new Word("cat", "wlecome cat to the world of cats");
      Assert.AreEqual(2, count.WordCount(count.Sentence));
    }
  }
}