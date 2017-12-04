using System;
using System.Linq;

namespace TicTacToe
{
  
    public class TicTacToe
    {
        public static void Main(string[] args)
        {
            /*1.Make board
             *2.Play
             *3.Check for winner
             *4.Check spaces left (if zero then draw)
             *5.Play again ... 
             *6.Clear board
            */

            var board = new TicTacToeBoard();
            var game = new TicTacToeGame(board);
            Console.WriteLine("Please play modafuckkers!! q to quit");

            var userInput = UpdateUi(board);
            while (userInput != "q")
            {
                if (int.TryParse(userInput, out var position))
                {
                    try
                    {
                        var result = game.Play(position);
                        if (result != GameState.Continue)
                        {
                            GameFinished(result, board);

                            board.Clear();
                            Console.WriteLine("Please play modafuckkers!! q to quit");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"{e.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number from 1 to 9");
                }

                userInput = UpdateUi(board);
            }
            
        }

        private static string UpdateUi(TicTacToeBoard board)
        {
            board.Display();
            var userInput = Console.ReadLine();
            return userInput;
        }

        private static void GameFinished(GameState result, TicTacToeBoard board)
        {
            if (result == GameState.XWins)
            {
                Console.WriteLine("X you badass!!");
            }
            else if (result == GameState.OWins)
            {
                Console.WriteLine("O is dope!!!");
            }
            else
            {
                Console.WriteLine("This game is rigged!");
            }
        }
    }
}
