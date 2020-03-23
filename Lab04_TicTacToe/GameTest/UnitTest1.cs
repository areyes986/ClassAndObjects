using System;
using Xunit;
using Lab04_TicTacToe;
using Lab04_TicTacToe.Classes;

namespace GameTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestForWinner()
        {

            string[,] testGameBoard = new string[,]
            {
            {"O", "2", "3"},
            {"4", "O", "6"},
            {"7", "8", "O"},
            };

            Player player1 = new Player();
            Player player2 = new Player();
            Game startGame = new Game(player1, player2);

            startGame.Board.GameBoard = testGameBoard;

            bool win = startGame.CheckForWinner(startGame.Board);

            Assert.True(win);
        }

        [Fact]
        public void PlayersCanSwitch()
        {
            Player player1 = new Player();
            player1.IsTurn = true;
            Player player2 = new Player();
            player2.IsTurn = false;
            Game startGame = new Game(player1, player2);
            
            startGame.SwitchPlayer();

            Assert.False(player1.IsTurn);
        }

        [Fact]
        public void CorrectInput()
        {
            Board testBoard = new Board();
            Position playerPosition = Player.PositionForNumber(4);
            string index = testBoard.GameBoard[playerPosition.Row, playerPosition.Column];
            Assert.Equal("4", index);
        }

        [Fact]
        public void CheckingYourTurn()
        {
            Player player1 = new Player();
            player1.Name = "Mochi";
            player1.IsTurn = true;
            Player player2 = new Player();
            player2.Name = "Kudo";
            player2.IsTurn = false;

            Game testGame = new Game(player1, player2);
            Player current = testGame.NextPlayer();
            Assert.Equal("Mochi", current.Name);


        }

    }
}
