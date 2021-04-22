using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      PrintUntilnumber(2);
      Console.ReadKey();
    }

    // Write your method here:
    public static void PrintUntilnumber(int number)
    {
       for (int i = number; i >= 1; i--)
       {
         Console.WriteLine(i); 
       }
    }
  }
}
