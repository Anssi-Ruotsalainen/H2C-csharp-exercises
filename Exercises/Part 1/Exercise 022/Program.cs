using System;

namespace exercise_22
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give the first number!");
      double Firstnumber = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Give the second number!");
      double Secondnumber = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Give the third number!");
      double Thirdnumber = Convert.ToDouble(Console.ReadLine());
            
      double Answer = (Firstnumber / Secondnumber) / Thirdnumber;  
      Console.WriteLine("The average is " +  Math.Round(Answer, 2));
      

      
      

      Console.ReadKey();
    }
  }
}
