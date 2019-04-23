using System;

namespace MasterMind
{
    class HitorMis
    {
        public static int CountHits(int[] rnArray, int[] userrnArray)
        {
            int hits = 0;

            Console.WriteLine("Misses are indicated with +");
            for (int i = 0; i < rnArray.Length; i++)
            {
                if (rnArray[i] != userrnArray[i])
                {
                    Console.WriteLine('+' + " \n");
                }
                else
                {
                    Console.WriteLine('0' + " \n");
                }
            }
            Console.WriteLine("Hits are indicated with -");
            for (int i = 0; i < rnArray.Length; i++)
            {
                if (rnArray[i]== userrnArray[i])
                {
                    Console.WriteLine('-' + " \n");
                    hits++;
                }
                else
                {
                    Console.WriteLine('0' + " \n");
                }
            }
            return hits;
        }
    }
}