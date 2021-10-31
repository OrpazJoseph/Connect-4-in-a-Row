using System;
using System.Drawing;
using System.Windows.Forms;
using Connect4Logic;

namespace Connect4Graphic
{
    public partial class FormGame : Form
    {
        Game game = new Game();
        InputValidation InputValidation = new InputValidation();

        private readonly Form r_FormSettings = Application.OpenForms["FormSettings"];

        private Button[,] m_ButtonMatrixToDisplay;
        private Button[] m_ButtonArrayToPlay;

        private GameBoard m_Matrix;

        private PlayerInfo m_Player1;
        private PlayerInfo m_Player2;

        private int m_PlayFirst;
        private int m_Rows;
        private int m_Cols;

        public FormGame()
        {
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void initSize()
        {
            int Cols = 220;
            int Rows = 302;

            for (int i = (int)((FormSettings)r_FormSettings).NumericUpDownCols.Value; i > (int)((FormSettings)r_FormSettings).NumericUpDownCols.Minimum; i--)
            {
                Cols += 40;
            }

            for (int i = (int)((FormSettings)r_FormSettings).NumericUpDownRows.Value; i > (int)((FormSettings)r_FormSettings).NumericUpDownRows.Minimum; i--)
            {
                Rows += 38;
            }

            Size = new Size(Cols, Rows);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            InitializeComponents();
        }

        private void InitializeComponents()
        {
            initSize();
            createBoard();
            
            if (m_Cols > 5)
            {
                for (int i = (int)((FormSettings)r_FormSettings).NumericUpDownCols.Value; i > (int)((FormSettings)r_FormSettings).NumericUpDownCols.Minimum; i--)
                {
                    playerOneLabel.Left += 15;
                }
            }
            playerOneLabel.Text = ((FormSettings)r_FormSettings).TextBoxPlayerOne.Text + ":    ";
            playerOneScore.Text = "0";

            int posNameHeight = ClientSize.Height - playerOneLabel.Height - 12;

            playerOneLabel.Top = posNameHeight;

            playerTwoLabel.Text = ((FormSettings)r_FormSettings).TextBoxPlayerTwo.Text + ":    ";
            playerTwoScore.Text = "0";
            playerTwoLabel.Top = posNameHeight;
            playerTwoLabel.Left = playerOneLabel.Right + 20;
            int scorePosition = playerOneLabel.Left + playerOneLabel.Width - 5;

            playerOneScore.Left = scorePosition;
            playerOneScore.Top = posNameHeight;
            scorePosition = playerTwoLabel.Left + playerTwoLabel.Width - 5;
            playerTwoScore.Location = new Point(scorePosition, posNameHeight);

            playerOneLabel.BackColor = Color.LightPink;
            playerTwoLabel.BackColor = Color.LightPink;
            playerOneScore.BackColor = Color.LightPink;
            playerTwoScore.BackColor = Color.LightPink;
            playerOneLabel.Font = new Font(DefaultFont, FontStyle.Bold);
            playerTwoLabel.Font = new Font(DefaultFont, FontStyle.Bold);
            playerOneScore.Font = new Font(DefaultFont, FontStyle.Bold);
            playerTwoScore.Font = new Font(DefaultFont, FontStyle.Bold);
            forfeitButton.Width = TextRenderer.MeasureText(forfeitButton.Text, forfeitButton.Font).Width + 2;

            int leftForfeitButtonPos = m_ButtonMatrixToDisplay[m_Rows - 1, m_Cols - 1].Right - forfeitButton.Width;

            forfeitButton.Top = playerTwoLabel.Top - 25;
            forfeitButton.Left = leftForfeitButtonPos;

            forfeitButton.Click += ForfeitButton_Click;
            gameInProgress();
        }

        private void createBoard()
        {
            m_ButtonArrayToPlay = new Button[(int)((FormSettings)r_FormSettings).NumericUpDownCols.Value];
            Point point = new Point(25, 20);

            for (int i = 0; i < m_ButtonArrayToPlay.Length; i++)
            {
                m_ButtonArrayToPlay[i] = new Button();
                m_ButtonArrayToPlay[i].Text = (i + 1).ToString();
                m_ButtonArrayToPlay[i].Location = point;
                m_ButtonArrayToPlay[i].Size = new Size(30, 20);
                m_ButtonArrayToPlay[i].BackColor = Color.LightCyan;

                point.Offset(40, 0);
                Controls.Add(m_ButtonArrayToPlay[i]);
                m_ButtonArrayToPlay[i].Click += FormGame_Click;
            }

            m_Rows = (int)((FormSettings)r_FormSettings).NumericUpDownRows.Value;
            m_Cols = (int)((FormSettings)r_FormSettings).NumericUpDownCols.Value;

            m_ButtonMatrixToDisplay = new Button[m_Rows, m_Cols];
            m_Matrix = new GameBoard(m_Rows, m_Cols);

            Point newPoint = new Point();

            for (int i = 0; i < m_Cols; i++)
            {
                newPoint.X = m_ButtonArrayToPlay[i].Left;
                newPoint.Y = m_ButtonArrayToPlay[i].Bottom + 15;

                for (int j = 0; j < m_Rows; j++)
                {
                    m_ButtonMatrixToDisplay[j, i] = new Button();
                    m_ButtonMatrixToDisplay[j, i].Location = newPoint;
                    m_ButtonMatrixToDisplay[j, i].Size = new Size(30, 30);
                    m_ButtonMatrixToDisplay[j, i].AutoSize = true;
                    m_ButtonMatrixToDisplay[j, i].BackColor = Color.LimeGreen;
                    newPoint.Y = m_ButtonMatrixToDisplay[j, i].Bottom + 10;
                    Controls.Add(m_ButtonMatrixToDisplay[j, i]);
                }
            }
        }

        private void gameInProgress()
        {
            if (!((FormSettings)r_FormSettings).CheckBoxPlayerTwo.Checked)
            {
                // P1vsPc
                m_Player1 = new PlayerInfo(((FormSettings)r_FormSettings).TextBoxPlayerOne.Text, 'X', false);
                m_Player2 = new PlayerInfo(((FormSettings)r_FormSettings).TextBoxPlayerTwo.Text, 'O', true);

                m_PlayFirst = 1;
            }
            else
            {
                // P1vsP2
                m_Player1 = new PlayerInfo(((FormSettings)r_FormSettings).TextBoxPlayerOne.Text, 'X', false);
                m_Player2 = new PlayerInfo(((FormSettings)r_FormSettings).TextBoxPlayerTwo.Text, 'O', false);
                playFirst();
            }
        }

        private void playFirst()
        {

            m_PlayFirst = game.WhoPlayFirst();
            if (m_PlayFirst == 1 && ((FormSettings)r_FormSettings).CheckBoxPlayerTwo.Checked)
            {
                MessageBox.Show(m_Player1.PlayerName + " Starts!");
            }
            else if (m_PlayFirst == 2)
            {
                MessageBox.Show(m_Player2.PlayerName + " Starts!");
            }
        }

        private void drawGame()
        {
            for (int i = m_Matrix.Board.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = m_Matrix.Board.GetLength(1) - 1; j >= 0; j--)
                {
                    m_ButtonMatrixToDisplay[i, j].Text = m_Matrix.Board[i, j].ToString();
                    m_ButtonMatrixToDisplay[i, j].Font = new Font(DefaultFont, FontStyle.Bold);
                    if (m_ButtonMatrixToDisplay[0, j].Text == "X" || m_ButtonMatrixToDisplay[0, j].Text == "O")
                    {
                        m_ButtonArrayToPlay[j].Enabled = false;
                    }
                }
            }
        }

        private bool checkIfWinOrDraw(PlayerInfo i_PlayFirst)
        {
            bool flag = false;

            if (Game.CheckIfWin(m_Matrix, i_PlayFirst))
            {
                drawGame();
                if (MessageBox.Show(
                    i_PlayFirst.PlayerName +
                    " Won!!" +
                    Environment.NewLine +
                    "Play another round?",
                    "A Win!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    i_PlayFirst.PlayerScore++;
                    if (i_PlayFirst == m_Player1)
                    {
                        playerOneScore.Text = i_PlayFirst.PlayerScore.ToString();
                        flag = true;
                        newGame();
                    }
                    else
                    {
                        playerTwoScore.Text = i_PlayFirst.PlayerScore.ToString();
                        flag = true;
                        newGame();
                    }
                }
                else
                {
                    i_PlayFirst.PlayerScore++;
                    flag = true;
                    Close();
                    showScore();
                }
            }
            else if (Game.CheckBoardFull(m_Matrix))
            {
                drawGame();
                if (MessageBox.Show(
                    "It's A Draw!!" +
                    Environment.NewLine +
                    "Play another round?",
                    "Draw!!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    flag = true;
                    newGame();
                }
                else
                {
                    flag = true;
                    Close();
                    showScore();
                }
            }

            return flag;
        }

        private void showScore()
        {
            if (((FormSettings)r_FormSettings).TextBoxPlayerTwo.Enabled)
            {
                MessageBox.Show(
                    m_Player1.PlayerName +
                    " Score: " +
                    m_Player1.PlayerScore +
                    Environment.NewLine +
                    m_Player2.PlayerName +
                    " Score: " +
                    m_Player2.PlayerScore,
                    "Score Summary",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    m_Player1.PlayerName +
                    " Score: " +
                    m_Player1.PlayerScore +
                    Environment.NewLine +
                    "Computer Score: " +
                    m_Player2.PlayerScore,
                    "Score Summary",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void newGame()
        {
            foreach (Control control in Controls)
            {
                control.Enabled = true;
                if (control is Button)
                {
                    control.ResetText();
                }
            }

            Reset();
            forfeitButton.Text = "Forfeit";
            if (!m_Player2.IsPc)
            {
                playFirst();
            }
        }

        internal void Reset()
        {
            for (int i = 0; i < m_Rows; i++)
            {
                for (int j = 0; j < m_Cols; j++)
                {
                    m_Matrix.Board[i, j] = '\0';
                }
            }

            int temp;

            for (int i = 0; i < m_Cols; i++)
            {
                temp = i + 1;
                m_ButtonArrayToPlay[i].Text = temp.ToString();
            }
        }

        private bool checkPlayerMove(int i_UserInput)
        {
            bool flag = false;

            if (m_Player2.IsPc)
            {
                flag = InputValidation.checkPlace(m_Matrix, i_UserInput, m_Player1);
                if (!checkIfWinOrDraw(m_Player1))
                {
                    game.SetPcMove(m_Matrix, m_Player2);
                    checkIfWinOrDraw(m_Player2);
                }
            }
            else
            {
                if (m_PlayFirst == 1)
                {
                    flag = InputValidation.checkPlace(m_Matrix, i_UserInput, m_Player1);
                    if (!checkIfWinOrDraw(m_Player1))
                    {
                        m_PlayFirst = 2;
                    }
                }
                else
                {
                    flag = InputValidation.checkPlace(m_Matrix, i_UserInput, m_Player2);
                    if (!checkIfWinOrDraw(m_Player2))
                    {
                        m_PlayFirst = 1;
                    }
                }
            }

            return flag;
        }

        private void FormGame_Click(object sender, EventArgs e)
        {
            Button chosenButton = sender as Button;
            int chosenCol = int.Parse(chosenButton.Text);

            if (checkPlayerMove(chosenCol))
            {
                drawGame();
            }
        }

        private void ForfeitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quit current match?", "Quit Match!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (m_PlayFirst == 1)
                {
                    m_Player2.PlayerScore++;
                    playerTwoScore.Text = m_Player2.PlayerScore.ToString();
                    if (MessageBox.Show("Play another round?", "Another Round?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        newGame();
                    }
                    else
                    {
                        Close();
                        showScore();
                    }
                }
                else
                {
                    m_Player1.PlayerScore++;
                    playerOneScore.Text = m_Player1.PlayerScore.ToString();
                    if (MessageBox.Show("Play another round?", "Another Round?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        newGame();
                    }
                    else
                    {
                        Close();
                        showScore();
                    }
                }
            }
        }
    }
}
