using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = -1;


        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess < magicNumber)
            {
                Console.Write("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.Write("Lower");
            }
            else
            {
                Console.WriteLine("You Guessed It!");
            }
        }
    }
}