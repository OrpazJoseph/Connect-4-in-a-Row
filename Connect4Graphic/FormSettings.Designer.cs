namespace Connect4Graphic
{
    public partial class FormSettings
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
            this.playersLabel = new System.Windows.Forms.Label();
            this.CheckBoxPlayerTwo = new System.Windows.Forms.CheckBox();
            this.playerOneLabel = new System.Windows.Forms.Label();
            this.TextBoxPlayerOne = new System.Windows.Forms.TextBox();
            this.TextBoxPlayerTwo = new System.Windows.Forms.TextBox();
            this.NumericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownCols = new System.Windows.Forms.NumericUpDown();
            this.rowsLabel = new System.Windows.Forms.Label();
            this.colsLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.boardSizeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownCols)).BeginInit();
            this.SuspendLayout();
            // 
            // playersLabel
            // 
            this.playersLabel.AutoSize = true;
            this.playersLabel.Location = new System.Drawing.Point(12, 9);
            this.playersLabel.Name = "playersLabel";
            this.playersLabel.Size = new System.Drawing.Size(44, 13);
            this.playersLabel.TabIndex = 0;
            this.playersLabel.Text = "Players:";
            // 
            // checkBoxPlayerTwo
            // 
            this.CheckBoxPlayerTwo.AutoSize = true;
            this.CheckBoxPlayerTwo.Location = new System.Drawing.Point(28, 62);
            this.CheckBoxPlayerTwo.Name = "checkBoxPlayerTwo";
            this.CheckBoxPlayerTwo.Size = new System.Drawing.Size(67, 17);
            this.CheckBoxPlayerTwo.TabIndex = 1;
            this.CheckBoxPlayerTwo.Text = "Player 2:";
            this.CheckBoxPlayerTwo.UseVisualStyleBackColor = true;
            this.CheckBoxPlayerTwo.CheckedChanged += new System.EventHandler(this.checkBoxPlayerTwo_CheckedChanged);
            // 
            // playerOneLabel
            // 
            this.playerOneLabel.AutoSize = true;
            this.playerOneLabel.Location = new System.Drawing.Point(25, 34);
            this.playerOneLabel.Name = "playerOneLabel";
            this.playerOneLabel.Size = new System.Drawing.Size(48, 13);
            this.playerOneLabel.TabIndex = 2;
            this.playerOneLabel.Text = "Player 1:";
            // 
            // textBoxPlayerOne
            // 
            this.TextBoxPlayerOne.Location = new System.Drawing.Point(101, 31);
            this.TextBoxPlayerOne.MaxLength = 10;
            this.TextBoxPlayerOne.Name = "textBoxPlayerOne";
            this.TextBoxPlayerOne.Size = new System.Drawing.Size(92, 20);
            this.TextBoxPlayerOne.TabIndex = 3;
            this.TextBoxPlayerOne.Text = "Player1";
            // 
            // textBoxPlayerTwo
            // 
            this.TextBoxPlayerTwo.Enabled = false;
            this.TextBoxPlayerTwo.Location = new System.Drawing.Point(101, 60);
            this.TextBoxPlayerTwo.MaxLength = 10;
            this.TextBoxPlayerTwo.Name = "textBoxPlayerTwo";
            this.TextBoxPlayerTwo.Size = new System.Drawing.Size(92, 20);
            this.TextBoxPlayerTwo.TabIndex = 4;
            this.TextBoxPlayerTwo.Text = "[Computer]";
            // 
            // numericUpDownRows
            // 
            this.NumericUpDownRows.Location = new System.Drawing.Point(77, 121);
            this.NumericUpDownRows.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDownRows.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumericUpDownRows.Name = "numericUpDownRows";
            this.NumericUpDownRows.Size = new System.Drawing.Size(32, 20);
            this.NumericUpDownRows.TabIndex = 5;
            this.NumericUpDownRows.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numericUpDownCols
            // 
            this.NumericUpDownCols.Location = new System.Drawing.Point(159, 121);
            this.NumericUpDownCols.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDownCols.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumericUpDownCols.Name = "numericUpDownCols";
            this.NumericUpDownCols.Size = new System.Drawing.Size(34, 20);
            this.NumericUpDownCols.TabIndex = 6;
            this.NumericUpDownCols.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // rowsLabel
            // 
            this.rowsLabel.AutoSize = true;
            this.rowsLabel.Location = new System.Drawing.Point(34, 123);
            this.rowsLabel.Name = "rowsLabel";
            this.rowsLabel.Size = new System.Drawing.Size(37, 13);
            this.rowsLabel.TabIndex = 7;
            this.rowsLabel.Text = "Rows:";
            // 
            // colsLabel
            // 
            this.colsLabel.AutoSize = true;
            this.colsLabel.Location = new System.Drawing.Point(126, 123);
            this.colsLabel.Name = "colsLabel";
            this.colsLabel.Size = new System.Drawing.Size(30, 13);
            this.colsLabel.TabIndex = 8;
            this.colsLabel.Text = "Cols:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(15, 168);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(178, 23);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // boardSizeLabel
            // 
            this.boardSizeLabel.AutoSize = true;
            this.boardSizeLabel.Location = new System.Drawing.Point(12, 96);
            this.boardSizeLabel.Name = "boardSizeLabel";
            this.boardSizeLabel.Size = new System.Drawing.Size(61, 13);
            this.boardSizeLabel.TabIndex = 10;
            this.boardSizeLabel.Text = "Board Size:";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 203);
            this.Controls.Add(this.boardSizeLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.colsLabel);
            this.Controls.Add(this.rowsLabel);
            this.Controls.Add(this.NumericUpDownCols);
            this.Controls.Add(this.NumericUpDownRows);
            this.Controls.Add(this.TextBoxPlayerTwo);
            this.Controls.Add(this.TextBoxPlayerOne);
            this.Controls.Add(this.playerOneLabel);
            this.Controls.Add(this.CheckBoxPlayerTwo);
            this.Controls.Add(this.playersLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect4 Game";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playersLabel;
        public System.Windows.Forms.CheckBox CheckBoxPlayerTwo;
        private System.Windows.Forms.Label playerOneLabel;
        public System.Windows.Forms.TextBox TextBoxPlayerOne;
        public System.Windows.Forms.TextBox TextBoxPlayerTwo;
        public System.Windows.Forms.NumericUpDown NumericUpDownRows;
        public System.Windows.Forms.NumericUpDown NumericUpDownCols;
        private System.Windows.Forms.Label rowsLabel;
        private System.Windows.Forms.Label colsLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label boardSizeLabel;
    }
}