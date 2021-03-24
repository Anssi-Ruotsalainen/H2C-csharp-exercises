using System;

namespace exercise_23
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give the first number!");
      int Firstnumber = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Give the second number!");
      int Secondnumber = Convert.ToInt32(Console.ReadLine());
      int Add = Firstnumber + Secondnumber;
      int Subtraction = Firstnumber - Secondnumber;
      int Multiply = Firstnumber * Secondnumber;
      double First =  Convert.ToDouble(Firstnumber);
      double Second = Convert.ToDouble(Secondnumber);
      double Division = First / Second;
      
      Console.WriteLine(Firstnumber + "+" + Secondnumber + "=" + Add);
      Console.WriteLine(Firstnumber + "-" + Secondnumber + "=" + Subtraction);
      Console.WriteLine(Firstnumber + "*" + Secondnumber + "=" + Multiply);
      Console.WriteLine(Firstnumber + "/" + Secondnumber + "=" + Math.Round(Division, 2));
      
      Console.ReadKey();      
            
    }
  }
}
