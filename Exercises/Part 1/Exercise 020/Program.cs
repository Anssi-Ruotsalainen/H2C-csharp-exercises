using System;

namespace exercise_20
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give the first number!");
      string T1 = Console.ReadLine();
      int A1 = Convert.ToInt32(T1);
      Console.WriteLine("Give the second number!");
      string T2 = Console.ReadLine();
      int A2 = Convert.ToInt32(T2);

      int Answer = A1 * A2;
      Console.WriteLine(T1 + " * " + T2 + " = " + Answer);
            
      Console.ReadKey();
    }
  }
} 
	
