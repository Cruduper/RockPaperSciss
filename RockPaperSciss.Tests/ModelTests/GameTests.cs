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
      Game newGame = new Game("ROCK", "SCISSORS"); 
      Assert.AreEqual( typeof(Game), newGame.GetType());
    }

    [TestMethod]
    public void ReturnWinner_ReturnsPlayer1WinnerRockScissors_Player1Wins()
    {
      Game newGame = new Game("ROCK", "SCISSORS");
      Assert.AreEqual("Player 1 Wins" , newGame.ReturnWinner());
    }

    [TestMethod]
    public void ReturnWinner_ReturnsPlayer1WinnerPaperRock_Player1Wins()
    {
      Game newGame = new Game("PAPER", "ROCK");
      Assert.AreEqual("Player 1 Wins" , newGame.ReturnWinner());
    }

    [TestMethod]
    public void ReturnWinner_ReturnsPlayer1WinnerScissorsPaper_Player1Wins()
    {
      Game newGame = new Game("SCISSORS", "PAPER");
      Assert.AreEqual("Player 1 Wins" , newGame.ReturnWinner());
    }

    
    [TestMethod]
    public void ReturnWinner_ReturnsPlayer2WinnerScissorsRock_Player2Wins()
    {
      Game newGame = new Game("SCISSORS", "ROCK");
      Assert.AreEqual("Player 2 Wins" , newGame.ReturnWinner());
    }

    [TestMethod]
    public void ReturnWinner_ReturnsPlayer2WinnerRockPaper_Player2Wins()
    {
      Game newGame = new Game("ROCK", "PAPER");
      Assert.AreEqual("Player 2 Wins" , newGame.ReturnWinner());
    }

    [TestMethod]
    public void ReturnWinner_ReturnsPlayer2WinnerPaperScissors_Player2Wins()
    {
      Game newGame = new Game("PAPER", "SCISSORS");
      Assert.AreEqual("Player 2 Wins" , newGame.ReturnWinner());
    }

    [TestMethod]
    public void ReturnWinner_ReturnsDrawWhenMovesAreTheSame_Draw()
    {
      Game newGame = new Game("SCISSORS", "SCISSORS");
      Assert.AreEqual("Draw!" , newGame.ReturnWinner());
    }
    [TestMethod]
    public void ReturnWinner_ReturnsErrorIfNotRPS_Weird()
    {
      Game newGame = new Game("Plastic", "Pens");
      Assert.AreEqual("Someone input something weird!" , newGame.ReturnWinner());
    }

  }

}