using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};


		/// <summary>
		/// simply displays the board.
		/// </summary>
		public void DisplayBoard()
		{
			//TODO: Output the board to the console
			for (int i = 0; i < 3; i++)
			{
				Console.Write($"|{GameBoard[i, 0]}|");
				Console.Write($"|{GameBoard[i, 1]}|");
				Console.WriteLine($"|{GameBoard[i, 2]}|");
			}


		}
	}
}
