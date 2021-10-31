using System;
using System.Collections.Generic;
using System.Text;

namespace Connect4Logic
{
    public class InputValidation
    {
        public bool checkPlace(GameBoard i_Matrix, int i_Num, PlayerInfo i_CurrentPlayer)
        {
            bool flag = false;
            int rows = i_Matrix.Board.GetLength(0);

            while (rows != 0)
            {
                if (i_Matrix.Board[rows - 1, i_Num - 1] != 'X' && i_Matrix.Board[rows - 1, i_Num - 1] != 'O')
                {
                    i_Matrix.Board[rows - 1, i_Num - 1] = i_CurrentPlayer.PlayerId;
                    flag = true;
                    break;
                }

                rows--;
            }

            return flag;
        }
    }
}
