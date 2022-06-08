using System;

public class Kata
{
public static int[] ProcessArray(int[] arr, Func<int, int> callback)
  {
    int[] result = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = callback(arr[i]);
    }

    return result;
  }
}

//Write the processArray function, which takes an array and a callback function as parameters.
//The callback function can be, for example, a mathematical function that will be applied on each element of this array.
