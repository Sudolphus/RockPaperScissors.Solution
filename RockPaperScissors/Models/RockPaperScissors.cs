using System.Text.RegularExpressions;

namespace RockPaperScissors.Models
{
  public class Game
  {
    public static string DetectWinner(string player1, string player2)
    {
      if (player1 == player2) 
      {
        return "Draw";
      }
      else if (player1 == "rock" && player2 == "scissors" || player1 == "scissors" && player2 == "paper" || player1 == "paper" && player2 == "rock")
      {
        return "Player 1 Win";
      }
      else if (player1 == "rock" && player2 == "paper" || player1 == "scissors" && player2 == "rock" || player1 == "paper" && player2 == "scissors")
      {
        return "Player 2 Win";
      }
      return "An error has occured";
    }
    public static string ParseResponse(string playerInput)
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
  }
}