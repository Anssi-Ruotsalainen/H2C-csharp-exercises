using System;

namespace exercise_43
{
  class Program
  {
    public static void Main()
    {
      // Write your code here:
      Console.WriteLine("Add number ");
      int num1= Convert.ToInt32(Console.ReadLine());
      int num2= - 1;
            if (num1 > 0)
	        {
              int sum = num1 * num2;
              Console.WriteLine(sum);

	        }
            else
	        {
              Console.WriteLine(num1);   
	        } 
           
            
      Console.ReadKey();
    }
  }
}
