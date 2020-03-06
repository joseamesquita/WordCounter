using System;
using System.Collections.Generic;

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
  }
}