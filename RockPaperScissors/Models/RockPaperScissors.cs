using System;
using System.Text.RegularExpressions;

namespace RockPaperScissors.Models
{
  public class Game
  {
    private static Random rnd = new Random();

    public static string DetectWinner(string player1)
    {
      player1 = ParseResponse(player1);
      string player2 = AIResponse();
      if (player1 == player2) 
      {
        return "I picked " + player2 + "! We Drew!";
      }
      else if (player1 == "rock" && player2 == "scissors" || player1 == "scissors" && player2 == "paper" || player1 == "paper" && player2 == "rock")
      {
        return "I picked " + player2 + "! You Win!";
      }
      else if (player1 == "rock" && player2 == "paper" || player1 == "scissors" && player2 == "rock" || player1 == "paper" && player2 == "scissors")
      {
        return "I picked " + player2 + "! I Win!";
      }
      return "An error has occured";
    }
    private static string ParseResponse(string playerInput)
    {
      if (Regex.IsMatch(playerInput, "^rock$", RegexOptions.IgnoreCase))
      {
        return "rock";
      }
      if (Regex.IsMatch(playerInput, "^scissors$", RegexOptions.IgnoreCase))
      {
        return "scissors";
      }
      if (Regex.IsMatch(playerInput, "^paper$", RegexOptions.IgnoreCase))
      {
        return "paper";
      }
      return "An error has occured";
    }

    private static string AIResponse()
    {
      int randomChoice = rnd.Next(3);
      if (randomChoice == 0)
      {
        return "rock";
      }
      else if (randomChoice == 1)
      {
        return "paper";
      }
      else
      {
        return "scissors";
      }
    }
  }
}