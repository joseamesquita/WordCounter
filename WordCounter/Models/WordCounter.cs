using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
  public class Word
  {
    public string Input { get; set; }
    public string Sentence { get; set; }


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
      List<string> newSentence = sentence.Split(' ').ToList();
      string words = "";
      for (int i = 0; i < newSentence.Count; i++)
      {
        if (Input == newSentence[newSentence.Count - 1])
        {
          words += newSentence[i];
        }
        else
        {
          words += newSentence[i] + " ";
        }
      }
      return words;
      // foreach (string word in newSentence)
      // {
      //   if (word == newSentence[newSentence.Count - 1])
      //   {
      //     words += word;
      //   }
      //   else
      //   {
      //     words += word + " ";
      //   }
      // }
      // return words;

    }

    public void WordCount(string sentence)
    {
      string count = SplitSentence(sentence);
      // int quantity = 0;
      for (int i = 0; i < count.Length; i++)
      {
        Console.Write(count[0]);
      }
      // return quantity;
    }
  }
}