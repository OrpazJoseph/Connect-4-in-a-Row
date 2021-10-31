using System;
using System.Windows.Forms;

namespace Connect4Graphic
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void checkBoxPlayerTwo_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxPlayerTwo.Enabled = CheckBoxPlayerTwo.CheckState == CheckState.Checked;
            if (TextBoxPlayerTwo.Enabled)
            {
                TextBoxPlayerTwo.Text = "Player2";
            }
            else
            {
                TextBoxPlayerTwo.Text = "[Computer]";
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Hide();
            FormGame formGame = new FormGame();
            formGame.ShowDialog();
            Application.Exit();
        }
    }
}
