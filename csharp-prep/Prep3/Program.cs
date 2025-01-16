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

        Console.Write(" Hello! and welcome to my GUESS THE MAGIC NUMBER GAME,What is your guess?");
        guess = int.Parse(Console.ReadLine());

        if (magicNumber > guess)
        {
            Console.WriteLine("the magic number is Higher");

        }
        else if (magicNumber < guess)
        {
            Console.WriteLine("the Magic number is lower");

        }
        else {
            Console.WriteLine("You guessed it, great job");
        }


       }
    }

  
}