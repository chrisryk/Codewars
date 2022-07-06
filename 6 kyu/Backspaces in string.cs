using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Kata
{
  public static string CleanString(string s)
  {
      List<char> letters = s.ToList();

      for (int i = 0; i < letters.Count; i++)
      {
          if (letters[i] == '#' && i != 0)
          {
              letters.RemoveAt(i--);
              letters.RemoveAt(i--);
          }
          else if (letters[i] == '#' && i == 0)
          {
              letters.RemoveAt(i--);
          }
      }

      return string.Join("", letters);
  }
}

//Assume "#" is like a backspace in string. This means that string "a#bc#d" actually is "bd"

//Your task is to process a string with "#" symbols.
//Examples

//"abc#d##c"      ==>  "ac"
//"abc##d######"  ==>  ""
//"#######"       ==>  ""
//""              ==>  ""
