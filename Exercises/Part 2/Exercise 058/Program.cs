﻿using System;

namespace exercise_58
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Smallest(5, 9);
      Console.WriteLine("Smallest: " + answer);
      Console.ReadKey();
    }

    // Write your method here:
    public static int Smallest(int number1, int number2)
    {
            if (number1 > number2)
            {
              return number2;  
            }
            else
	        {
              return number1;
	        }

    }
  }
}
