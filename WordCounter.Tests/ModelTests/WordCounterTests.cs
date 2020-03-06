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
      List<string> inputList = new List<string>();
      Word testWord = new Word("cat", inputList);
      Assert.AreEqual(typeof(Word), testWord.GetType());
    }
    [TestMethod]
    public void CheckWord_ChecksForDigitInWord_ReturnsTrue()
    {
      List<string> inputList = new List<string>();
      Word testWord = new Word("cat1", inputList);
      Assert.AreEqual(true, testWord.CheckWord(testWord.Input));
    }
  }
}