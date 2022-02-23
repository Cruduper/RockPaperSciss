using System;
using System.Collections.Generic;
using RockPaperSciss.Model;
using System.Threading;

namespace RockPaperSciss
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Rock, Paper, Scissors!");
      Console.WriteLine("Player 1, please enter in your move (Rock, Paper, Scissors): ");
      Console.WriteLine("Press <Enter> to submit your turn... ");
      string p1Move = "";
      ConsoleKeyInfo tempChar = Console.ReadKey(true);
      while (tempChar.Key != ConsoleKey.Enter) {
        p1Move += tempChar.Key;
        tempChar = Console.ReadKey(true);
      }
      
      
      //ConsoleKeyInfo  p1MoveKey = Console.ReadKey(true);
      Console.WriteLine("Now, Player 2, please enter in your move (Rock, Paper, Scissors): ");
      Console.WriteLine("Press <Enter> to submit your turn... ");
      string p2Move = "";
      tempChar = Console.ReadKey(true);
      while (tempChar.Key != ConsoleKey.Enter) {
        p2Move += tempChar.Key;
        tempChar = Console.ReadKey(true);
      }
      Game game = new Game(p1Move, p2Move);
      string result = game.ReturnWinner();
      Console.WriteLine( result );
      Console.WriteLine( "\n\n\np1 input: " + p1Move + "    p2 input: " + p2Move + "\n\n\n" );
      Console.Write("Would you like to play again? Yes or No: ");
      if (Console.ReadLine() == "Yes")
      {
        Main();
      }
    }
  }
}