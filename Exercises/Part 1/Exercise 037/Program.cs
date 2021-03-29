using System;

namespace exercise_37
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
                   count = count + 1;
                   
	           }
                if (number > 0)
	           {
                  count = count + 1;
	           }
         
	  }        
      Console.WriteLine("How many numbers " + count);
      Console.ReadKey();
    }
  }
}
