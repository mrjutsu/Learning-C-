using System;

namespace MorseTranslator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write(": ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                string output = MorseCodeTranslator.ToMorse(input);

                Console.WriteLine(output);
            }
        }
    }
}
