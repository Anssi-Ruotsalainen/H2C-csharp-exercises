using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give number ");
      int number = Convert.ToInt32(Console.ReadLine());
      for (int i = 0; i < number +1; i++)
	  {
                Console.WriteLine(i);
	  }
      Console.ReadKey();
    }
    
  }
}
