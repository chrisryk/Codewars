using System;

public class StringMerger
{
    public static bool isMerge(string s, string part1, string part2)
    {
        int counterPart1 = 0;
        int counterPart2 = 0;

        foreach (var item in s)
        {
            if (counterPart1 < part1.Length && item.Equals(part1[counterPart1]))
                counterPart1++;
            else if (counterPart2 < part2.Length && item.Equals(part2[counterPart2]))
                counterPart2++;
            else if (counterPart2 < part2.Length && (item.Equals(part2[counterPart2 + 1]) || item.Equals(part2[counterPart2 + 2])))
            {
                counterPart1--;
                counterPart2 += 2;
            }
            else
                return false;
        }
      
        if (counterPart1 != part1.Length || counterPart2 != part2.Length)
          return false;
        return true;
    }
}

//At a job interview, you are challenged to write an algorithm to check if a given string, s, can be formed from two other strings, part1 and part2.

//The restriction is that the characters in part1 and part2 should be in the same order as in s.

//The interviewer gives you the following example and tells you to figure out the rest from the given test cases.

//For example:

//'codewars' is a merge from 'cdw' and 'oears':

//    s:  c o d e w a r s   = codewars
//part1:  c   d   w         = cdw
//part2:    o   e   a r s   = oears
