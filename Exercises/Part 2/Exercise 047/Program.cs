using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Where to ");
      int answer = Convert.ToInt32(Console.ReadLine());
      for (int i = 1; i < answer +1; i++)
	  {
                Console.WriteLine(i);
	  }
      Console.ReadKey();
    }
  }
}
