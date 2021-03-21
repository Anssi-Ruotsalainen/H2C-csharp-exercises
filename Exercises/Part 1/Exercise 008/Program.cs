using System;

namespace exercise_08
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine ("What is your name?");
            string answer = Console.ReadLine();
            Console.WriteLine("Hey! " + answer + "!");
            
            Console.ReadKey();
        }        
    }
}

