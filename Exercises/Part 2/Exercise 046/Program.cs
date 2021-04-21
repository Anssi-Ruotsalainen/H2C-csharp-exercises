using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give number ");
      int number = Convert.ToInt32(Console.ReadLine());
      int end = 100;
      for (int i = number; i < end; i++)
	  {
                Console.WriteLine(i);
	  }
      Console.ReadKey();
    }
  }
}
