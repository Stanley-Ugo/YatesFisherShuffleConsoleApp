using System;
using Algorithms;

namespace AlgorithmsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letters = { "A", "B", "C", "D", "E" };

            //letters.DoFisherYatesShuffle();

            letters.DoFisherYatesAlternativeShuffle();

            foreach (string letter in letters)
                Console.Write(letter + " ");

            Console.ReadLine();
        }
    }
}
