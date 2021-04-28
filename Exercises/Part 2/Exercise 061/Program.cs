using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
            
            ChristmasTree(10);
            PrintSpaces(8);
            PrintStars(3);
            PrintSpaces(8);
            PrintStars(3);

            Console.ReadKey();

    }

    public static void PrintStars(int number)
    {
             for (int i = 0; i < number; i++)
			 { 
                Console.Write("*"); 
			 }
             Console.WriteLine(" ");

    }

    public static void PrintSpaces(int space)
    {
             for (int i = 0; i < space; i++)
			{
                Console.Write(" "); 
			}
            
    }

    public static void PrintRightTriangle(int size)
    {
            for (int i = 1; i <= size; i++)
			{
                for (int j = 1; j <= size - i; j++)
			    {
                    Console.Write(" ");
			    }
                for (int k = 1; k <= i; k++)
			    {
                    Console.Write("*");

			    }
                Console.WriteLine(" ");

			}

    }

    public static void ChristmasTree(int height)
    {
         for (int i = 1; i <= height; i++)
	     {
               for (int j = 1; j <= (height - i); j++)
               {
                    Console.Write(" ");
                  
               } 

               for (int t = 1; t < i * 2; t++)
               {
                    Console.Write("*");

               }
	           Console.WriteLine(" ");

		 }
           
            
    }
  }
}
