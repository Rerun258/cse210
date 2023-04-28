using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 1000);
        int guess = 0;
        do
        {
            
            Console.Write("What is the magic number: ");
            string answer = Console.ReadLine();
            guess = int.Parse(answer);

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess == number)
            {
                Console.WriteLine("You Guessed it");
            }
        } while (guess != number);

    }
}