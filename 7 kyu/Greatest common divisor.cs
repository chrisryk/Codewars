public class Kata
{
  public static int Gcd(int a, int b) => (b == 0) ? a : Gcd(b, a % b);
}

//public class Kata
//{
//  public static int Gcd(int a, int b) => (a == b) ? a : (a > b) ? Gcd(a - b, b) : Gcd(a, b - a);
//}

//Find the greatest common divisor of two positive integers. The integers can be large, so you need to find a clever solution.

//The inputs x and y are always greater or equal to 1, so the greatest common divisor will always be an integer that is also greater or equal to 1.
