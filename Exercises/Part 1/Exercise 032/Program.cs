using System;

namespace exercise_32
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Speak, friend, and enter!");
      string answer = Console.ReadLine();
      bool result = false;

            if (answer == "Mellon")
	{
                result = true;
                Console.WriteLine("Welcome, friend");
	}
            else
	{
                result = false;
                Console.WriteLine("They've got a cave troll!");
   	}
     

      Console.ReadKey();
    }
  }
}
