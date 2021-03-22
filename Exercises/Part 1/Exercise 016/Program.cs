using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("How many days?");
      string second = Console.ReadLine();
      int answer = Convert.ToInt32(second);  
      Console.WriteLine(answer * 60 * 60 * 24 );

      Console.ReadKey();
    }
  }
}
