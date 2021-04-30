using System;
using System.Collections.Generic;

namespace exercise_69
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
       
        
      Console.WriteLine("From where");
      int start = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("To where");
      int end = Convert.ToInt32(Console.ReadLine());

      for (int index = start; index < end + 1; index++)
	  {
         if (list.Count >= start && list.Count <= end)
	     {
           Console.WriteLine(list[index]);
	     }
             
	  }
      Console.ReadKey();
        
       

    }
  }
}
