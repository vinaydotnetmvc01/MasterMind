using System;

namespace MasterMind
{
    //
    class GetUser
    {
        public static int[] GetUserGuess(int userInputSize)
        {
            int number = 0;
            int[] userGuess = new int[userInputSize];
            for (int i = 0; i < userInputSize; i++)
            {
                Console.Write("Digit {0}: ", (i + 1));
                while (!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 6)
                    Console.WriteLine("Invalid number!");
                userGuess[i] = number;
            }

            Console.WriteLine();
            Console.Write("Your guess: ");
            for (int i = 0; i < userInputSize; i++)
            {
                Console.Write(userGuess[i] + " ");
            }

            Console.WriteLine();
            return userGuess;
        }
    }
}