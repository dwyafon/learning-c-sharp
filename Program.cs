using System;

namespace learning_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey Dale. How was the Black Lodge?");
            string input = Console.ReadLine();
            Console.WriteLine($"Confirmed. It was {input}.");

            double doubleCone = 2.1;

            int newCone = (int)doubleCone;
        }
    }
}

