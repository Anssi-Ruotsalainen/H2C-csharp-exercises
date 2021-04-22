using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      
      PrintUntilnumber(6);
      Console.ReadKey();
    }
    
    // Write your method here:
    public static void PrintUntilnumber(int number)
    {
       for (int i = 1; i < number +1; i++)
       {
         Console.WriteLine(i);  
       }
    }
  }
}
