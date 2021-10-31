namespace Connect4Logic
{
    public class PlayerInfo
    {
        private string m_PlayerName;
        private char m_PlayerId;
        private int m_PlayerScore;
        private bool m_IsPc;
        
        private enum ePlayerID
        {
            O = 1,
            X
        }

        public PlayerInfo(string i_Name, char i_Id, bool i_IsPc)
        {
            m_PlayerName = i_Name;
            m_PlayerId = i_Id;
            m_PlayerScore = 0;
            m_IsPc = i_IsPc;
        }

        public PlayerInfo(char i_Id)
        {
            m_PlayerName = string.Empty;
            PlayerId = i_Id;
            m_PlayerScore = 0;
            m_IsPc = false;
        }

        public string PlayerName
        {
            get
            {
                return m_PlayerName;
            }

            set
            {
                m_PlayerName = value;
            }
        }

        public char PlayerId
        {
            get
            {
                return m_PlayerId;
            }

            set
            {
                if (value == (char)ePlayerID.X || value == (char)ePlayerID.O)
                {
                    m_PlayerId = value;
                }
            }
        }

        public int PlayerScore
        {
            get
            {
                return m_PlayerScore;
            }

            set
            {
                m_PlayerScore = value;
            }
        }

        public bool IsPc
        {
            get
            {
                return m_IsPc;
            }

            set
            {
                m_IsPc = value;
            }
        }
    }
}
