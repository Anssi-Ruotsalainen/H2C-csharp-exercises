using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Speak, friend, and enter!");
      string firstanswer = Console.ReadLine();
      string secondanswer = Console.ReadLine();
      bool result = false;

            if (firstanswer == secondanswer)
	{
                result = true;
                Console.WriteLine("Echo!");
	}
            else
	{
                result = false;
                Console.WriteLine("Nope!");
   	}
     

      Console.ReadKey();
    }
  }
}
