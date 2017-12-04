using System;
using System.Linq;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        private string _nextTurn = "X";

        private ITicTacToeBoard Board { get; }

        public TicTacToeGame(ITicTacToeBoard board)
        {
            Board = board;
        }

        public GameState Play(int position)
        {
            var boardState = Board.Change(position, _nextTurn);

            if(_nextTurn == "X")
            {
                _nextTurn = "O";
            }
            else
            {
                _nextTurn = "X";
            }

            var result = IsWinningState(boardState);

            if (result == "No winner")
            {
                return IsGameOver(boardState) ? GameState.Draw : GameState.Continue;
            }

            return result == "X" ? GameState.XWins : GameState.OWins;
        }

        public string IsWinningState(string[] boardState)
        {
            if (boardState[0] == boardState[1] && boardState[1] == boardState[2])
            {
                var winner = (boardState[0] == "X") ? "X" : "O";
                return winner;
            }
            if (boardState[3] == boardState[4] && boardState[4] == boardState[5])
            {
                var winner = (boardState[3] == "X") ? "X" : "O";
                return winner;
            }
            if (boardState[6] == boardState[7] && boardState[8] == boardState[7])
            {
                var winner = (boardState[6] == "X") ? "X" : "O";
                return winner;
            }
            if (boardState[0] == boardState[3] && boardState[6] == boardState[3])
            {
                var winner = (boardState[0] == "X") ? "X" : "O";
                return winner;
            }
            if (boardState[1] == boardState[4] && boardState[4] == boardState[7])
            {
                var winner = (boardState[1] == "X") ? "X" : "O";
                return winner;
            }
            if (boardState[2] == boardState[5] && boardState[5] == boardState[8])
            {
                var winner = (boardState[2] == "X") ? "X" : "O";
                return winner;
            }
            if (boardState[0] == boardState[4] && boardState[8] == boardState[4])
            {
                var winner = (boardState[0] == "X") ? "X" : "O";
                return winner;
            }
            if (boardState[2] == boardState[4] && boardState[4] == boardState[6])
            {
                var winner = (boardState[2] == "X") ? "X" : "O";
                return winner;
            }
            
            return "No winner";
        }

        public bool IsGameOver(string[] boardState)
        {
            return !boardState.Any(element => (element != "X") && (element != "O"));
        }
    }
}