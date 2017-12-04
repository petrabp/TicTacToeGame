namespace TicTacToe
{
    public interface ITicTacToeBoard
    {
        string[] Change(int position, string player);

        void Clear();

        void Display();
    }
}