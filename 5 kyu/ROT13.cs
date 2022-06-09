using System;
using System.Globalization;
using System.Text;

public class Kata
{
  public static string Rot13(string input)
  {
    StringBuilder stringBuilder = new StringBuilder("");

    foreach (var character in input)
    {
        int characterCode = ((int)character + 13);

        if (char.GetUnicodeCategory(character) == UnicodeCategory.UppercaseLetter)
        {
            stringBuilder.Append(char.ConvertFromUtf32((characterCode > 90) ? characterCode - 26 : characterCode));
            continue;
        }
        else if (char.GetUnicodeCategory(character) == UnicodeCategory.LowercaseLetter)
        {
            stringBuilder.Append(char.ConvertFromUtf32((characterCode > 122) ? characterCode - 26 : characterCode));
            continue;
        }
        stringBuilder.Append(character);
    }
    return stringBuilder.ToString();
  }
}

//How can you tell an extrovert from an introvert at NSA? Va gur ryringbef, gur rkgebireg ybbxf ng gur BGURE thl'f fubrf.
//I found this joke on USENET, but the punchline is scrambled. Maybe you can decipher it? According to Wikipedia,
//ROT13 (http://en.wikipedia.org/wiki/ROT13) is frequently used to obfuscate jokes on USENET.
//Hint: For this task you're only supposed to substitue characters. Not spaces, punctuation, numbers etc.
