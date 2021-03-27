using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give me your percent [0 - 100]:");
      int answer = Convert.ToInt32(Console.ReadLine());

            if (answer < 0)
	{
                Console.WriteLine("impossible");
	}
            else if (answer <= 49)
	{
                Console.WriteLine("Fail");
	}
            else if (answer <= 59)
	{
                Console.WriteLine("Grade is: 1");
	}
            else if (answer <= 69)
	{
                Console.WriteLine("Grade is: 2");
	}
            else if (answer <= 79)
	{
                Console.WriteLine("Grade is: 3");
	}
            else if (answer <= 89)
	{
                Console.WriteLine("Grage is: 4");
	}
            else if (answer <= 100)
	{
                Console.WriteLine("Grade is: 5");
	}
            else
	{
              Console.WriteLine("Outstanding!");
	}

     Console.ReadKey();
    }

   
  }
}
