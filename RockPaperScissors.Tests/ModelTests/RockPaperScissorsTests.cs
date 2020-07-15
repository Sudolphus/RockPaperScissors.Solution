using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class RockPaperScissorsTests
  {
    [TestMethod]
    public void DetectWinner_DeterminesADraw_Draw()
    {
      Assert.AreEqual("Draw", Game.DetectWinner("rock", "rock"));
      Assert.AreEqual("Draw", Game.DetectWinner("paper", "paper"));
      Assert.AreEqual("Draw", Game.DetectWinner("scissors", "scissors"));
    }
    [TestMethod]
    public void DetectWinner_RockVScissors_Player1Win()
    {
      Assert.AreEqual("Player 1 Win", Game.DetectWinner("rock","scissors"));
    }
    [TestMethod]
    public void DetectWinner_RockVPaper_Player2Win()
    {
      Assert.AreEqual("Player 2 Win", Game.DetectWinner("rock", "paper"));
    }
    [TestMethod]
    public void DetectWinner_ScissorsVRock_Player2Win()
    {
      Assert.AreEqual("Player 2 Win", Game.DetectWinner("scissors", "rock"));
    }
    [TestMethod]
    public void DetectWinner_ScissorsVPaper_Player1Win()
    {
      Assert.AreEqual("Player 1 Win", Game.DetectWinner("scissors", "paper"));
    }
    [TestMethod]
    public void DetectWinner_PaperVRock_Player1Win()
    {
      Assert.AreEqual("Player 1 Win", Game.DetectWinner("paper", "rock"));
    }
    [TestMethod]
    public void DetectWinner_PaperVScissors_Player2Win()
    {
      Assert.AreEqual("Player 2 Win", Game.DetectWinner("paper", "scissors"));
    }

    [TestMethod]
    public void ParseResponse_IgnoreCaseForRock_Rock()
    {
      string player1Parsed = Game.ParseResponse("RoCk");
      Assert.AreEqual("rock", player1Parsed);
    }

    [TestMethod]
    public void ParseResponse_IgnoreCaseForScissors_Scissors()
    {
      string player1Parsed = Game.ParseResponse("SciSSOrs");
      Assert.AreEqual("scissors", player1Parsed);
    }

    [TestMethod]
    public void ParseResponse_IgnoreCaseForPaper_Paper()
    {
      string player1Parsed = Game.ParseResponse("PAPER");
      Assert.AreEqual("paper", player1Parsed);
    }

    [TestMethod]
    public void DetectWinner_CanDetectWinnerWithParsedResponse_Player1Win()
    {
      Assert.AreEqual("Player 1 Win", Game.DetectWinner("RoCk", "SCISSORS"));
    }
  }
}