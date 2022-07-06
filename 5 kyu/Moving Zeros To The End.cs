public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
      for (int i = 0; i < arr.Length; i++)
      {
          if (arr[i] == 0 && i < arr.Length - 1)
          {
              int index = i;

              for (int j = index + 1; j < arr.Length; j++)
              {
                  if (arr[index] == 0 && arr[j] == 0)
                  {
                      continue;
                  }

                  arr[index] = arr[j];
                  arr[j] = 0;
                  index++;
              }
          }
      }
      return arr;
  }
}

/*
Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}
*/
