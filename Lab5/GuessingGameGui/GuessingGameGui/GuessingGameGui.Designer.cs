namespace GuessingGameGui
{
    partial class frmGuessingGameGui
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainMenu = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuFileNewGame = new ToolStripMenuItem();
            mnuFileExit = new ToolStripMenuItem();
            lblInstructions = new Label();
            lblIncorrectGuesses = new Label();
            lblIncorrectGuessesOutput = new Label();
            lblNumbersRemaining = new Label();
            lblNumbersRemainingOutput = new Label();
            statusStrip1 = new StatusStrip();
            stblOutput = new ToolStripStatusLabel();
            lstOutput = new ListBox();
            mainMenu.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.ImageScalingSize = new Size(20, 20);
            mainMenu.Items.AddRange(new ToolStripItem[] { mnuFile });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Padding = new Padding(10, 3, 0, 3);
            mainMenu.Size = new Size(432, 25);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileNewGame, mnuFileExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(37, 19);
            mnuFile.Text = "&File";
            // 
            // mnuFileNewGame
            // 
            mnuFileNewGame.Name = "mnuFileNewGame";
            mnuFileNewGame.Size = new Size(132, 22);
            mnuFileNewGame.Text = "&New Game";
            mnuFileNewGame.Click += mnuFileNewGame_Click;
            // 
            // mnuFileExit
            // 
            mnuFileExit.Name = "mnuFileExit";
            mnuFileExit.Size = new Size(132, 22);
            mnuFileExit.Text = "E&xit";
            mnuFileExit.Click += exitToolStripMenuItem_Click;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Font = new Font("Segoe UI", 10.2F);
            lblInstructions.Location = new Point(94, 42);
            lblInstructions.Margin = new Padding(5, 0, 5, 0);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(236, 19);
            lblInstructions.TabIndex = 1;
            lblInstructions.Text = "Guess a number between 1 and 100!";
            // 
            // lblIncorrectGuesses
            // 
            lblIncorrectGuesses.AutoSize = true;
            lblIncorrectGuesses.Font = new Font("Segoe UI", 10.2F);
            lblIncorrectGuesses.Location = new Point(12, 321);
            lblIncorrectGuesses.Name = "lblIncorrectGuesses";
            lblIncorrectGuesses.Size = new Size(120, 19);
            lblIncorrectGuesses.TabIndex = 3;
            lblIncorrectGuesses.Text = "Incorrect Guesses:";
            // 
            // lblIncorrectGuessesOutput
            // 
            lblIncorrectGuessesOutput.BorderStyle = BorderStyle.Fixed3D;
            lblIncorrectGuessesOutput.Font = new Font("Segoe UI", 10.2F);
            lblIncorrectGuessesOutput.Location = new Point(138, 321);
            lblIncorrectGuessesOutput.Name = "lblIncorrectGuessesOutput";
            lblIncorrectGuessesOutput.Size = new Size(39, 25);
            lblIncorrectGuessesOutput.TabIndex = 4;
            lblIncorrectGuessesOutput.Text = "0";
            lblIncorrectGuessesOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumbersRemaining
            // 
            lblNumbersRemaining.AutoSize = true;
            lblNumbersRemaining.Font = new Font("Segoe UI", 10.2F);
            lblNumbersRemaining.Location = new Point(236, 321);
            lblNumbersRemaining.Name = "lblNumbersRemaining";
            lblNumbersRemaining.Size = new Size(136, 19);
            lblNumbersRemaining.TabIndex = 5;
            lblNumbersRemaining.Text = "Numbers Remaining:";
            // 
            // lblNumbersRemainingOutput
            // 
            lblNumbersRemainingOutput.BorderStyle = BorderStyle.Fixed3D;
            lblNumbersRemainingOutput.Font = new Font("Segoe UI", 10.2F);
            lblNumbersRemainingOutput.Location = new Point(378, 321);
            lblNumbersRemainingOutput.Name = "lblNumbersRemainingOutput";
            lblNumbersRemainingOutput.Size = new Size(39, 25);
            lblNumbersRemainingOutput.TabIndex = 6;
            lblNumbersRemainingOutput.Text = "100";
            lblNumbersRemainingOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { stblOutput });
            statusStrip1.Location = new Point(0, 357);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(432, 26);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // stblOutput
            // 
            stblOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stblOutput.Name = "stblOutput";
            stblOutput.Size = new Size(417, 21);
            stblOutput.Spring = true;
            stblOutput.Text = "Pick a number to guess!";
            stblOutput.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lstOutput
            // 
            lstOutput.ColumnWidth = 40;
            lstOutput.DisplayMember = "1";
            lstOutput.FormattingEnabled = true;
            lstOutput.ItemHeight = 25;
            lstOutput.Location = new Point(12, 63);
            lstOutput.MultiColumn = true;
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(405, 254);
            lstOutput.TabIndex = 2;
            lstOutput.Click += lstOutput_Click;
            // 
            // frmGuessingGameGui
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 383);
            Controls.Add(lstOutput);
            Controls.Add(statusStrip1);
            Controls.Add(lblNumbersRemainingOutput);
            Controls.Add(lblNumbersRemaining);
            Controls.Add(lblIncorrectGuessesOutput);
            Controls.Add(lblIncorrectGuesses);
            Controls.Add(lblInstructions);
            Controls.Add(mainMenu);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = mainMenu;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "frmGuessingGameGui";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guessing Game";
            Load += frmGuessingGameGui_Load;
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileNewGame;
        private ToolStripMenuItem mnuFileExit;
        private Label lblInstructions;
        private Label lblIncorrectGuesses;
        private Label lblIncorrectGuessesOutput;
        private Label lblNumbersRemaining;
        private Label lblNumbersRemainingOutput;
        private StatusStrip statusStrip1;
        private ListBox lstOutput;
        private ToolStripStatusLabel stblOutput;
    }
}
