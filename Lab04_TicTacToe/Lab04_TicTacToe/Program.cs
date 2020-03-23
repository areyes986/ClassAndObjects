using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PlayGame();
        }
        
        static void PlayGame()
        {
            Console.WriteLine("Player 1, what is your name?");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("Player 2, what is your name?");
            string userInput2 = Console.ReadLine();

            Player player1 = new Player();
            player1.Name = userInput1;
            player1.Marker = "X";
            player1.IsTurn = false;

            Player player2 = new Player();
            player2.Name = userInput2;
            player2.Marker = "O";
            player2.IsTurn = true;


            Game startGame = new Game(player1, player2);
            Player winner = startGame.Play();

            if (winner.Name == "draw")
            {
                Console.WriteLine("Draw!");
            }
            else
            {
                Console.WriteLine($"Yay! You won, {winner.Name}.");
            }



        }
        // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
        // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
    }
}
