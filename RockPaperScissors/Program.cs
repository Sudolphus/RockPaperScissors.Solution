using System;
using RockPaperScissors.Models;

namespace RockPaperScissors.Program
{
  public class RPSProgram
  {
    public static void Main()
    {
      Console.WriteLine("Let's play Rock, Paper, Scissors!");
      Console.WriteLine("Player, make your pick! [type rock, paper, or scissors]");
      string player = Console.ReadLine();
      Console.WriteLine(Game.DetectWinner(player));
    }
  }
}