using System;

namespace exercise_09
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, How are you doing?");
            string FirstAnswer = Console.ReadLine();
            Console.WriteLine("Really! Nice" + "\n" + "Are your sure?");
            string SecondAnswer = Console.ReadLine();
            Console.WriteLine("Why did you say then? " + FirstAnswer);
            string ThirdAnswer = Console.ReadLine();
            Console.WriteLine("Thx!, Anyways");

            //CMD FIX
            Console.ReadKey();

        }
    }
}
