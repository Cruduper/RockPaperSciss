using System;

// 1. Game myGame = new Game();

// string output = myGame.checkForWinner(player-1-input, player-2-input);

// output = Player 1 wins
// player 2 wins
// draw - if draw, recall Main()


// [TestMethod]
// CheckWhenPlayer1HasRockAndPlayer2HasScissor_Player1Wins
// Assert("Player 1 Wins", myGame.CheckForWinner("Rock","Scissor")


namespace RockPaperSciss.Model
{
  public class Game
  {
    private string Player1Move; 
    private string Player2Move;
    public Game(string player1Move, string player2Move)
    {
      Player1Move = player1Move;
      Player2Move = player2Move;
    }
    
    public string ReturnWinner()
    {
      string result = "";
      if((Player1Move=="Rock")&&(Player2Move=="Scissors"))
      {
        result= "Player 1 Wins";
      } else if((Player1Move=="Paper")&&(Player2Move=="Rock"))
      {
        result= "Player 1 Wins";
      }
      else if((Player1Move=="Scissors")&&(Player2Move=="Paper"))
      {
        result= "Player 1 Wins";
      }
        else if((Player1Move=="Scissors")&&(Player2Move=="Rock"))
      {
        result= "Player 2 Wins";
      }
      else if((Player1Move=="Rock")&&(Player2Move=="Paper"))
      {
        result= "Player 2 Wins";
      }
      else if((Player1Move=="Paper")&&(Player2Move=="Scissors"))
      {
        result= "Player 2 Wins";
      }
      else if (Player1Move==Player2Move)
      {
        result= "Draw!";
      }
      return result;

      
    }
  }

  
}

