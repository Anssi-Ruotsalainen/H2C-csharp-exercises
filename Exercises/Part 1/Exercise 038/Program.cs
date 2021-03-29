using System;

namespace exercise_38
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
                   
                   continue;
	           }
            
         
	  }        
      Console.WriteLine("amount of negative numbers " + count);
      Console.ReadKey();
    }
  }
}
