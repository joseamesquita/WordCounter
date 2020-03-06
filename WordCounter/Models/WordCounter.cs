using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Word
  {
    public string input { get; set; }
    public List<string> inputList = new List<string>();


    public Word(string word)
    {

    }
  }
}