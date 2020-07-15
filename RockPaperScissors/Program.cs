using System;
using RockPaperScissors.Models;

namespace RockPaperScissors.Program
{
  public class RPSProgram
  {
    public static void Main()
    {
      Console.WriteLine("Let's play Rock, Paper, Scissors!");
      bool playAgain = true;
      while (playAgain)
      {
        Console.WriteLine("Player, make your pick! [type rock, paper, or scissors]");
        string player = Console.ReadLine();
        Console.WriteLine(Game.DetectWinner(player));
        Console.WriteLine("Do you want to play again? [Y/N]");
        string response = Console.ReadLine();
        if (response != "Y" && response != "y") {
          Console.WriteLine("Goodbye!");
          playAgain = false;
        }
      }
    }
  }
}