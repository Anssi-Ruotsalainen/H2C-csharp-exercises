﻿using System;

namespace exercise_13
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number!");
      string number = Console.ReadLine();
      double value = Convert.ToDouble(number);
      Console.WriteLine("You gave " + number);

      Console.ReadKey();
    }
  }
}
