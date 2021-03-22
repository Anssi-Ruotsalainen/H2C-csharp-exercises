using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
         Console.WriteLine("I will tell a story, but I need some information." + "\n"
                            + "Give a name for main character:");
         string AnswerOne = Console.ReadLine();       
         Console.WriteLine("Give the character a profession:");        
         string AnswerTwo = Console.ReadLine();
         Console.WriteLine("Morning come and sun started shining " + AnswerOne + " Need to wake up and go to school" + "\n"
                          + "He was already late first studies " + AnswerOne + " Was going to be " + AnswerTwo + "\n"           
                          + "After two years studies");
        //CMD FIX
         Console.ReadKey();
        }
    }
}
