using System;

public class Kata 
{
  public static double Arithmetic(double a, double b, string op) 
  {
    switch (op)
    {
      case "add":
        return a + b;
      case "subtract":
        return a - b;
      case "multiply":
        return a * b;
      case "divide":
        return (b != 0) ? a / b : default;
      default:
        return default;
    }
  }
}

//Given two numbers and an arithmetic operator (the name of it, as a string), return the result of the two numbers having that operator used on them.
//a and b will both be positive integers, and a will always be the first number in the operation, and b always the second.
//The four operators are "add", "subtract", "divide", "multiply". 
