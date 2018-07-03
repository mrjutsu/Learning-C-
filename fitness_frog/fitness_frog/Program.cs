using System;

namespace fitness_frog
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Prompt the user for minutes excercised
            Console.Write("Enter how many minutes you excercised: ");

            string entry = Console.ReadLine();

            // Add minutes excercised to total
            // Display total minutes excercised to the screen
            Console.WriteLine("You've entered " + entry + " minutes");

            // Repeat until the user quits
        }
    }
}
