using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int  n1;
      int n2;
      int sum;
      Console.WriteLine("Add first number ");
      n1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Add second number ");
      n2 = Convert.ToInt32(Console.ReadLine());
      sum = n1 + n2;      
      double squareRoot = Math.Sqrt(sum);
      Console.WriteLine(squareRoot);

      Console.ReadKey();
    
    }
  }
}
