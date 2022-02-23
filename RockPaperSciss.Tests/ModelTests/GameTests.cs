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
    public void ReturnWinner_ReturnsPlayer1WinnerRockScissors_Player1Wins()
    {
      Game newGame = new Game("Rock", "Scissors");
      Assert.AreEqual("Player 1 Wins" , newGame.ReturnWinner());
    }

    [TestMethod]
    public void ReturnWinner_ReturnsPlayer1WinnerPaperRock_Player1Wins()
    {
      Game newGame = new Game("Paper", "Rock");
      Assert.AreEqual("Player 1 Wins" , newGame.ReturnWinner());
    }

    [TestMethod]
    public void ReturnWinner_ReturnsPlayer1WinnerScissorsPaper_Player1Wins()
    {
      Game newGame = new Game("Scissors", "Paper");
      Assert.AreEqual("Player 1 Wins" , newGame.ReturnWinner());
    }

    
    [TestMethod]
    public void ReturnWinner_ReturnsPlayer2WinnerScissorsRock_Player2Wins()
    {
      Game newGame = new Game("Scissors", "Rock");
      Assert.AreEqual("Player 2 Wins" , newGame.ReturnWinner());
    }

    [TestMethod]
    public void ReturnWinner_ReturnsPlayer2WinnerRockPaper_Player2Wins()
    {
      Game newGame = new Game("Rock", "Paper");
      Assert.AreEqual("Player 2 Wins" , newGame.ReturnWinner());
    }

    [TestMethod]
    public void ReturnWinner_ReturnsPlayer2WinnerPaperScissors_Player2Wins()
    {
      Game newGame = new Game("Paper", "Scissors");
      Assert.AreEqual("Player 2 Wins" , newGame.ReturnWinner());
    }

    [TestMethod]
    public void ReturnWinner_ReturnsDrawWhenMovesAreTheSame_Draw()
    {
      Game newGame = new Game("Scissors", "Scissors");
      Assert.AreEqual("Draw!" , newGame.ReturnWinner());
    }

  }

}