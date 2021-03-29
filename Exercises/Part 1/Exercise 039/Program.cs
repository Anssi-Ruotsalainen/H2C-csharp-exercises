using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int count = 0; 
       while (true)
	  { 
         
         Console.WriteLine("Give a number:");
         int number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
	           {
                    break;

	           }
                if (number < 0)
	           {
                   count = count + number;
                   
	           }
                if (number > 0)
	           {
                   count = count + number; 
	           }
            
         
	  }        
      Console.WriteLine("Total sum of numbers: " + count);
      Console.ReadKey();
    }
  }
}
