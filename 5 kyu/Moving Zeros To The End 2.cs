using System.Linq;

public class Kata
{
  public static int[] MoveZeroes(int[] arr) => arr.OrderBy(x => x == 0).ToArray();
}

/*
Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.
Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}
*/
