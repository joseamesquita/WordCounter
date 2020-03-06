using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
  public class Word
  {
    public string Input { get; set; }
    public string Sentence { get; set; }

    public int Count { get; set; }


    public Word(string word, string sentence)
    {
      Input = word;
      Sentence = sentence;
    }

    public bool CheckWord(string word)
    {
      foreach (char letter in word)
      {
        if (!Char.IsLetter(letter))
        {
          return false;
        }
        break;
      }
      return true;
    }

    public string SplitSentence(string sentence)
    {
      string[] newSentence = sentence.Split(' ');
      List<string> outcome = new List<string>();
      Count = 0;
      // string words = "";
      foreach (string word in newSentence)
      {
        if (Input == word)
        {
          outcome.Add(word);
          Count++;
        }
        else
        {
          outcome.Add(word);
        }
      }
      return String.Join(" ", outcome.ToArray());
    }

    // public void WordCount(string sentence)
    // {
    //   Count = 0;
    //   string count = SplitSentence(sentence);
    //   for (int i = 0; i < count.Length; i++)
    //   {
    //     if (Input == count[i])
    //     {
    //       Count++;
    //     }
    //   }
    //   // int quantity = 0;
    //   // foreach (string word in count)
    //   // {
    //   //   Console.Write(count[0]);
    //   // }
    //   // return quantity;
    // }
  }
}