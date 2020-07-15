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
      else if (player1 == "rock" && player2 == "scissors" || player1 == "scissors" && player2 == "paper")
      {
        return "Player 1 Win";
      }
      else if (player1 == "rock" && player2 == "paper" || player1 == "scissors" && player2 == "rock")
      {
        return "Player 2 Win";
      }
      

      return "dummy data so compiler doesn't complain";
    }
  }
}