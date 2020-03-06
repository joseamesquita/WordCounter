using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Word
  {
    public string Input { get; set; }
    public List<string> InputList = new List<string>();


    public Word(string word, List<string> inputList)
    {
      Input = word;
      InputList = inputList;
    }
  }
}