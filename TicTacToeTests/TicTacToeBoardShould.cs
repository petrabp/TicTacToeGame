using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TicTacToe;

namespace TicTacToeTests
{
    public class TicTacToeBoardShould
    {
        [TestCase(1, "X")]
        [TestCase(2, "X")]
        [TestCase(3, "X")]
        [TestCase(4, "X")]
        [TestCase(5, "X")]
        [TestCase(6, "X")]
        [TestCase(7, "X")]
        [TestCase(8, "X")]
        [TestCase(9, "X")]
        public void Place_symbols_in_correct_locations(int position, string player)
        {
            var ticTacToe = new TicTacToeBoard();
            var board = ticTacToe.Change(position, player);
            Assert.That(board[position - 1], Is.EqualTo(player));
        }

        [Test]
        public void Error_if_position_is_played()
        {
            var ticTacToe = new TicTacToeBoard();
            ticTacToe.Change(2, "X");
            Assert.Throws<ArgumentException>(() => ticTacToe.Change(2, "O"));
        }
    }
}
