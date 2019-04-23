using System;

namespace MasterMind
{
    class Game
    {
        public static void Play()
        {
            int rnDigitCount = RandomNumber.GetRandomNumberCount();

            int[] rnArray = RandomNumber.GenerateRandomNumbers(rnDigitCount);

            int numberofAttempts = 10;

            bool won = false;
            for (int allowedAttempts = numberofAttempts; allowedAttempts > 0 && !won; allowedAttempts--)
            {
                Console.WriteLine("\n({0} guesses remaining)", allowedAttempts);

                int[] userArray = GetUser.GetUserGuess(rnDigitCount);

                if (HitorMis.CountHits(rnArray, userArray) == rnDigitCount)
                    won = true;
            }

            if (won)
                Console.WriteLine("You win!");
            else
                Console.WriteLine("You couldn't guess the right number.");

            Console.Write("The correct number is: ");
            for (int j = 0; j < rnDigitCount; j++)
                Console.Write(rnArray[j] + " ");
            Console.WriteLine();
        }
    }
}