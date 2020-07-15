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
  }
}