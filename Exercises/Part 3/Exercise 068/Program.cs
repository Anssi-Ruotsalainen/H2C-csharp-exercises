﻿using System;
using System.Collections.Generic;

namespace exercise_68
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        list.Add(input);
      }
      for (int index = 0; index < list.Count; index++)
	  {
        Console.WriteLine(list[index]);
	  }

      Console.ReadKey();

    }
  }
}
