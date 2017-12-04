using System;
using System.Linq;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using TicTacToe;

namespace TicTacToeTests
{
    [TestFixture]
    public class TicTacToeShould
    {
        [Test]
        [TestCase(11)]
        [TestCase(0)]
        public void Error_on_invalid_position(int position)
        {
            var board = new TicTacToeBoard();

            var ticTacToe = new TicTacToeGame(board);

            Assert.Throws<ArgumentOutOfRangeException>(() => ticTacToe.Play(position));
        }
        
        //[Test]
        //public void Allow_only_X_to_play_first()
        //{
        //    var ticTacToeGame = new TicTacToe.TicTacToe();

        //    ticTacToeGame.Play(5);

        //    Assert.AreEqual("X", ticTacToeGame.Board[4]);
        //}

        //[Test]
        //public void Alternate_players()
        //{
        //    var ticTacToeGame = new TicTacToe.TicTacToe();

        //    ticTacToeGame.Play(1);
        //    ticTacToeGame.Play(2);
        //    ticTacToeGame.Play(3);

        //    Assert.AreEqual("X", ticTacToeGame.Board[0]);
        //    Assert.AreEqual("O", ticTacToeGame.Board[1]);
        //    Assert.AreEqual("X", ticTacToeGame.Board[2]);
        //}

        
        [TestCase("X X X 0 5 6 7 8 9")]
        [TestCase("1 2 3 X X X 7 8 9")]
        [TestCase("1 2 3 4 5 6 X X X")]
        [TestCase("X 2 3 X 5 6 X 8 9")]
        [TestCase("1 X 3 4 X 6 7 X 9")]
        [TestCase("1 2 X 4 5 X 7 8 X")]
        [TestCase("X 2 3 4 X 6 7 8 X")]
        [TestCase("1 2 X 4 X 6 X 8 9")]
        public void Declare_winner_for_X(string boardString)
        {
            var boardState = boardString.Split(' ');

            var board = new TicTacToeBoard();
            var ticTacToe = new TicTacToeGame(board);

            var result = ticTacToe.IsWinningState(boardState);

            Assert.That(result, Is.EqualTo("X"));
        }

        [Test]
        [TestCase("O O O 4 5 6 7 8 9")]
        [TestCase("1 2 3 O O O 7 8 9")]
        [TestCase("1 2 3 4 5 6 O O O")]
        [TestCase("O 2 3 O 5 6 O 8 9")]
        [TestCase("1 O 3 4 O 6 7 O 9")]
        [TestCase("1 2 O 4 5 O 7 8 O")]
        [TestCase("O 2 3 4 O 6 7 8 O")]
        [TestCase("1 2 O 4 O 6 O 8 9")]
        public void Declare_winner_for_O(string boardString)
        {
            var boardState = boardString.Split(' ');
            var board = new TicTacToeBoard();

            var ticTacToe = new TicTacToeGame(board);

            var result = ticTacToe.IsWinningState(boardState);

            Assert.That(result, Is.EqualTo("O"));
        }

        [Test]
        [TestCase("1 O 3 4 O 6 7 O 9", false)]
        [TestCase("X O X X O X O X O", true)]
        public void Check_that_game_is_not_over(string boardString, bool done)
        {
            var boardState = boardString.Split(' ');

            var board = new TicTacToeBoard();
            var ticTacToeGame = new TicTacToeGame(board);

            var result = ticTacToeGame.IsGameOver(boardState);

            Assert.That(result, Is.EqualTo(done));
        }


        //[Test]
        //[TestCase("O 2 3 4 O 6 7 8 O")]
        //[TestCase("1 2 O 4 O 6 O 8 9")]
        //public void Clear_board_when_there_is_a_winner_or_when_board_is_full(string boardString)
        //{
        //    var boardState = boardString.Split(' ');

        //    var ticTacToe = new TicTacToe.TicTacToe();

        //    // ticTacToe.ClearBoard(boardState);

        //    for (var i = 0; i < 8; i++)
        //    {
        //        Assert.AreEqual(ticTacToe.Board[i], $"{i + 1}");
        //    }
        //}

            
           
           
    }

}
