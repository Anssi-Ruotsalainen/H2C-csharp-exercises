using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Call your method here:
      Console.WriteLine("how many times ");
      int input = Convert.ToInt32(Console.ReadLine());
      PrintPhrase(input);
      Console.ReadKey();
 
    }

    // Write your method here:
    public static void PrintPhrase(int  times) 
    {
        
        int i = 0;
        while (i < times)
        {
          Console.WriteLine("In a hole in the ground there lived a method");
          i++;
        }

    }
  }
}
