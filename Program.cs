using System;

namespace guess_number
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine("Guess my number.");
      Random rnd = new Random();
      bool playing = true;
      int tries = 0;
      int computerNumber = rnd.Next(1, 101);
      while (playing)
      {
        Console.WriteLine("What's your guess?");
        string guess = Console.ReadLine();
        int playerNumber;
        if (!Int32.TryParse(guess, out playerNumber) || playerNumber < 1 || playerNumber > 100)
        {
          System.Console.WriteLine("Invalid input. A number between 1 and 100, please.");
          continue;
        };
        if (computerNumber == playerNumber)
        {
          tries++;
          Console.WriteLine($"You guessed it! It only took you {tries} guesses.");
          System.Console.WriteLine("Play Again? (select y for 'yes')");
          ConsoleKeyInfo decision = Console.ReadKey();
          if (decision.KeyChar == 'y')
          {
            tries = 0;
            computerNumber = rnd.Next(1, 101);
            Console.Clear();
          }
          else
          {
            Console.Clear();
            playing = false;
          }
        }
        else if (computerNumber > playerNumber)
        {
          tries++;
          Console.WriteLine("You guessed too low.");
          continue;
        }
        else
        {
          tries++;
          Console.WriteLine("You guessed too high.");
          continue;
        }
      }

    }
  }
}
