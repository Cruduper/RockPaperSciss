using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperSciss.Model;
using System;

namespace RockPaperSciss.Tests
{

  [TestClass]
  public class GameTests
  {


    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      Game newGame = new Game("Rock", "Scissors"); 
      Assert.AreEqual( typeof(Game), newGame.GetType());
    }

    [TestMethod]
    public void ReturnWinner_ReturnsAWinner_Player1Wins()
    {
      Game newGame = new Game("Rock", "Scissors");
      Assert.AreEqual("Player 1 Wins" , newGame.ReturnWinner());
    }

  }

}