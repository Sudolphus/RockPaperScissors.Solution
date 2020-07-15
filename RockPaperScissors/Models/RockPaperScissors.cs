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
      return "dummy data so compiler doesn't complain";
    }
  }
}