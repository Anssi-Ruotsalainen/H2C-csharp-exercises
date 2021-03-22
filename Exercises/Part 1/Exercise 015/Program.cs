using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give a string");
        string What = Console.ReadLine();
      Console.WriteLine("Give an integer:");
        string Number = Console.ReadLine();
        int AnswerOne = Convert.ToInt32(Number);
      Console.WriteLine("Give a double:");
        string Double = Console.ReadLine();
        double AnswerTwo = Convert.ToDouble(Double);
      Console.WriteLine("Give a boolean:"); 
        string Boolean = Console.ReadLine();
        bool Answertree = Convert.ToBoolean(Boolean);
            
      Console.WriteLine("Your String: " + What);
      Console.WriteLine("Your integer: " + AnswerOne);
      Console.WriteLine("Your double: " + AnswerTwo);
      Console.WriteLine("Your boolean: " + Answertree);      
      
      Console.ReadKey();
    }
  }
}
