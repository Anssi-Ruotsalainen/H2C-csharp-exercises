using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
     int first = Convert.ToInt32(Console.ReadLine());
     int second = Convert.ToInt32(Console.ReadLine());
     bool Firstbigger = first > second;
     bool Secondbigger = first < second;
     bool Equal = first == second;
     if (Firstbigger)
	{
        Console.WriteLine("is bigger " + first);
	}
     else if (Secondbigger)
	{
        Console.WriteLine("is bigger " + second);
	}
     else
	{
        Console.WriteLine("equal");
	}
	
        
	
	
        
	
     Console.ReadKey();
	}
  }
}
