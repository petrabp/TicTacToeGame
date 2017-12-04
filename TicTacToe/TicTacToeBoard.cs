using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToeBoard : ITicTacToeBoard
    {
        private string[] Board { get; set; }

        public TicTacToeBoard()
        {
            Clear();
        }

        public string[] Change(int position, string player)
        {
            InputValidation(position);

            Board[position - 1] = player;

            return Board;
        }

        public void Clear()
        {
            Board = new[] {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
        }

        public void Display()
        {
            Console.WriteLine(Board[0] + " " + Board[1] + " " + Board[2]);
            Console.WriteLine(Board[3] + " " + Board[4] + " " + Board[5]);
            Console.WriteLine(Board[6] + " " + Board[7] + " " + Board[8]);
        }

        private void InputValidation(int position)
        {
            if (position < 1 || position > 9)
            {
                throw new ArgumentException($"Invalid position {position}");
            }

            var currentValue = Board[position - 1];
            if (currentValue == "X" || currentValue == "O")
            {
                throw new ArgumentException("Position taken");
            }
        }

    }
}
