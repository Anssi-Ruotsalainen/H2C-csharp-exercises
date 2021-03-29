using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
       Console.WriteLine("Give a number:");
       int answer;
       

      
        while (true)
	   {
           
           int sum = Convert.ToInt32(Console.ReadLine());
           if (sum < 0)
	      {
            Console.WriteLine("negative");
             
	      }
           if (sum > 0)
	      {
            Console.WriteLine(answer = sum * sum);
	      }
           if (sum == 0)
	      {
            break;
	      } 
	      Console.WriteLine("Give a number:");
	      
        
          
       }
       
       Console.ReadKey();
    }
  }
}
