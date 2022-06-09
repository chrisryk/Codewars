using System;

public class Kata
{
  public static string BreakCamelCase(string str)
  {
    for (int i = 0; i < str.Length; i++)
    {
      if (char.IsUpper(str[i]))
      {
          str = str.Substring(0, i) + " " + str.Substring(i);
          i++;
      }
    }
    return str;
  }
}

//Complete the solution so that the function will break up camel casing, using a space between words.
