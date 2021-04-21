using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int sum = 0;
      int valid = 0; 
      double average = 0;  
      int even = 0;
      int odd = 0;      
      Console.WriteLine("Give numbers ");

            while (true)
	        {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == -1)
	            {  
                    break;
	            }
                if (input < 0)
                { 
                    continue;
                    
                }
                sum += input;
                valid++;
                average = sum / valid;
                if (input%2 == 0)
	            {
                    even++;
	            }
                else
	            {
                    odd++;
	            }
            }   
            Console.WriteLine("Thx! Bye! "); 
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Numbers " + valid);
            Console.WriteLine("Average " + average);
            Console.WriteLine("Even " + even);
            Console.WriteLine("Odd " + odd);
            
            Console.ReadKey();
    }
    
       
  }
}
