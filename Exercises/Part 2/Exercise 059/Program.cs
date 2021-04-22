using System;

namespace exercise_59
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = GrEatest(1, 8, 7);
      Console.WriteLine("Greatest: " + answer);
      Console.ReadKey();
    }

    // Write your method here:
    public static int GrEatest(int number1, int number2, int number3)
    {
            if (number1 > number2)
	        {
                if (number1 > number3)
	            {
                    return number1;
	            }
                else
                {
                    return number3;
                }
	        }
            else if (number2 > number3)
            {
                return number2;
            }
            else
            {
                return number3;
            }
    }
  }
}
