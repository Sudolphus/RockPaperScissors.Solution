using System;
using RockPaperScissors.Models;

namespace RockPaperScissors.Program
{
  public class RPSProgram
  {
    public static void Main()
    {
      Console.WriteLine("Let's play Rock, Paper, Scissors!");
      Console.WriteLine("Player 1, make your pick! [type rock, paper, or scissors]");
      string player1 = Console.ReadLine();
      Console.WriteLine("Player 2, make your pick! [type rock, paper, or scissors]");
      string player2 = Console.ReadLine();
      Console.WriteLine(Game.DetectWinner(player1, player2));
    }
  }
}