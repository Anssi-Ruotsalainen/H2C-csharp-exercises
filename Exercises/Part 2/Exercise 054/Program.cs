using System;

namespace exercise_54
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      DivisibleByThreeInRange(2, 10);
      Console.ReadKey();

    }

    // Write your method here:
    public static void DivisibleByThreeInRange(int A, int B)
	{
            int count = 0;
            for (int i = A; i <= B; i++)
			{
                if (i%3 == 0)
                {
                   count++;
                   Console.WriteLine(i);
                }
			}
            return;
			

	}

  }
}
