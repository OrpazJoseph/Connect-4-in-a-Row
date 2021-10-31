using System;
using System.Collections.Generic;
using System.Text;

namespace Connect4Logic
{
    public class Game
    {
        // Decides who will start first
        public int WhoPlayFirst()
        {
            Random rnd = new Random();

            return rnd.Next(1, 3);
        }

        // If game is against PC, makes random moves and set the value if it's a valid move
        public void SetPcMove(GameBoard i_Matrix, PlayerInfo i_CurrentPlayer)
        {
            int cols = i_Matrix.Board.GetLength(1);

            if (i_CurrentPlayer.IsPc)
            {
                while (true)
                {
                    Random pcMove = new Random();
                    int move = pcMove.Next(1, cols + 1);
                    InputValidation inputValidation = new InputValidation();

                    if (inputValidation.checkPlace(i_Matrix, move, i_CurrentPlayer))
                    {
                        return;
                    }
                }
            }
        }

        public static bool CheckIfWin(GameBoard i_Matrix, PlayerInfo i_CurrentPlayer)
        {
            char input = i_CurrentPlayer.PlayerId;
            int rows = i_Matrix.Board.GetLength(0) - 1;
            int cols = i_Matrix.Board.GetLength(1) - 1;
            bool flag = false;

            // Horizontal check
            for (int i = rows; i >= 0; i--)
            {
                for (int j = cols; j > 2; j--)
                {
                    if (i_Matrix.Board[i, j] == input && i_Matrix.Board[i, j - 1] == input && i_Matrix.Board[i, j - 2] == input && i_Matrix.Board[i, j - 3] == input)
                    {
                        flag = true;
                    }
                }
            }

            // Vertical check
            for (int i = rows; i > 2; i--)
            {
                for (int j = cols; j >= 0; j--)
                {
                    if (i_Matrix.Board[i, j] == input && i_Matrix.Board[i - 1, j] == input && i_Matrix.Board[i - 2, j] == input && i_Matrix.Board[i - 3, j] == input)
                    {
                        flag = true;
                    }
                }
            }

            // Diagonally check
            for (int i = rows; i > 2; i--)
            {
                for (int j = cols; j > 2; j--)
                {
                    if (i_Matrix.Board[i, j] == input && i_Matrix.Board[i - 1, j - 1] == input && i_Matrix.Board[i - 2, j - 2] == input && i_Matrix.Board[i - 3, j - 3] == input)
                    {
                        flag = true;
                    }

                    if (i_Matrix.Board[i, j - 3] == input && i_Matrix.Board[i - 1, j - 2] == input && i_Matrix.Board[i - 2, j - 1] == input && i_Matrix.Board[i - 3, j] == input)
                    {
                        // Reverse Diagonally check
                        flag = true;
                    }
                }
            }

            return flag;
        }

        // Checks if game board is full
        public static bool CheckBoardFull(GameBoard i_Matrix)
        {
            int countChars = 0;

            for (int i = 0; i < i_Matrix.Board.GetLength(1); i++)
            {
                if (i_Matrix.Board[0, i] == 'X' || i_Matrix.Board[0, i] == 'O')
                {
                    countChars++;
                }
            }

            return countChars == i_Matrix.Board.GetLength(1);
        }
    }
}
