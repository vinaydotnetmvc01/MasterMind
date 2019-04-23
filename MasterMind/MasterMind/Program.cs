using System;

namespace MasterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MasterMind");
            do
            {
                Game.Play();
                Console.Write("\nWould you like to play again (Y/N)? ");
            } while (Console.ReadLine().ToUpper() == "Y");
        }
    }
}
