using System;
using System.Collections.Generic;
using System.Text;

namespace Connect4Logic
{
    public class GameBoard
    {
        private char[,] m_Board;

        public GameBoard(int i_Rows, int i_Columns)
        {
            m_Board = new char[i_Rows, i_Columns];
        }

        public char[,] Board
        {
            get
            {
                return m_Board;
            }
        }
    }
}
