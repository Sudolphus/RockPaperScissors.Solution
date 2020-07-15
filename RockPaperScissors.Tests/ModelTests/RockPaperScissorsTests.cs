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
  }
}