using System;
using System.Linq;

public static class Kata
{
  public static string Order(string words)
  {
    string[] wordsList = words.Split(' ');
    string[] result = new string[wordsList.Length];

    foreach (string word in wordsList)
    {
      foreach (char character in word)
      {
          if (char.IsDigit(character))
          {
              result[(int)char.GetNumericValue(character) - 1] = word;
          }
      }
    }

    return string.Join(' ', result);
  }
}

//Your task is to sort a given string. Each word in the string will contain a single number. This number is the position the word should have in the result.
//Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).
//If the input string is empty, return an empty string. The words in the input String will only contain valid consecutive numbers.
