using System;

namespace exercise_18
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give the first number!");
            string First = Console.ReadLine();
            int FirstValue = Convert.ToInt32(First);
      Console.WriteLine("Give the second number!");
            string Second = Console.ReadLine();
            int SecondValue = Convert.ToInt32(Second);
      Console.WriteLine("Give the third number!");
            string Third = Console.ReadLine();
            int ThirdValue = Convert.ToInt32(Third);

            int Answer = FirstValue + SecondValue + ThirdValue;
      Console.WriteLine("The sum is" + "\n" + Answer);

      Console.ReadKey();
    }
  }
}
