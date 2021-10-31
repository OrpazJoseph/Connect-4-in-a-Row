namespace Connect4Graphic
{
    public partial class FormGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playerOneLabel = new System.Windows.Forms.Label();
            this.playerTwoLabel = new System.Windows.Forms.Label();
            this.playerOneScore = new System.Windows.Forms.Label();
            this.playerTwoScore = new System.Windows.Forms.Label();
            this.forfeitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerOneLabel
            // 
            this.playerOneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playerOneLabel.AutoSize = true;
            this.playerOneLabel.Location = new System.Drawing.Point(-2, 258);
            this.playerOneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerOneLabel.Name = "playerOneLabel";
            this.playerOneLabel.Size = new System.Drawing.Size(51, 20);
            this.playerOneLabel.TabIndex = 0;
            this.playerOneLabel.Text = "label1";
            // 
            // playerTwoLabel
            // 
            this.playerTwoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playerTwoLabel.AutoSize = true;
            this.playerTwoLabel.Location = new System.Drawing.Point(171, 258);
            this.playerTwoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerTwoLabel.Name = "playerTwoLabel";
            this.playerTwoLabel.Size = new System.Drawing.Size(51, 20);
            this.playerTwoLabel.TabIndex = 1;
            this.playerTwoLabel.Text = "label2";
            // 
            // playerOneScore
            // 
            this.playerOneScore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.playerOneScore.AutoSize = true;
            this.playerOneScore.Location = new System.Drawing.Point(48, 258);
            this.playerOneScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerOneScore.Name = "playerOneScore";
            this.playerOneScore.Size = new System.Drawing.Size(51, 20);
            this.playerOneScore.TabIndex = 2;
            this.playerOneScore.Text = "label1";
            // 
            // playerTwoScore
            // 
            this.playerTwoScore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.playerTwoScore.AutoSize = true;
            this.playerTwoScore.Location = new System.Drawing.Point(230, 258);
            this.playerTwoScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerTwoScore.Name = "playerTwoScore";
            this.playerTwoScore.Size = new System.Drawing.Size(51, 20);
            this.playerTwoScore.TabIndex = 1;
            this.playerTwoScore.Text = "label2";
            // 
            // forfeitButton
            // 
            this.forfeitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.forfeitButton.AutoSize = true;
            this.forfeitButton.Location = new System.Drawing.Point(153, 218);
            this.forfeitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.forfeitButton.Name = "forfeitButton";
            this.forfeitButton.Size = new System.Drawing.Size(69, 35);
            this.forfeitButton.TabIndex = 3;
            this.forfeitButton.Text = "Forfeit";
            this.forfeitButton.UseVisualStyleBackColor = true;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(397, 281);
            this.Controls.Add(this.forfeitButton);
            this.Controls.Add(this.playerOneScore);
            this.Controls.Add(this.playerTwoScore);
            this.Controls.Add(this.playerTwoLabel);
            this.Controls.Add(this.playerOneLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connect 4 in A Raw!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerOneLabel;
        private System.Windows.Forms.Label playerTwoLabel;
        private System.Windows.Forms.Label playerOneScore;
        private System.Windows.Forms.Label playerTwoScore;
        private System.Windows.Forms.Button forfeitButton;
    }
}