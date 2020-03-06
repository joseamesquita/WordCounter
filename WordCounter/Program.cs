using System;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      Word printSentence = new Word("cat", "welcome cat to the world of cats cat cat");
      Console.Write(printSentence.SplitSentence(printSentence.Sentence));
      Console.WriteLine();
      Console.WriteLine(printSentence.Count);
    }
  }
}