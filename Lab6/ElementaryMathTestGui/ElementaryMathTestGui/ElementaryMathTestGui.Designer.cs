namespace ElementaryMathTestGui
{
    partial class frmElementaryMathTestGui
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
            lblTotalQuestions = new Label();
            nudTotalQuestions = new NumericUpDown();
            lblMinimum = new Label();
            lblMaximum = new Label();
            nudMaximum = new NumericUpDown();
            nudMinimum = new NumericUpDown();
            lblQuestions = new Label();
            lblQuestionsOutput = new Label();
            lblRight = new Label();
            lblRightOutput = new Label();
            lblWrong = new Label();
            lblWrongOutput = new Label();
            btnTakeTest = new Button();
            btnExit = new Button();
            btnReset = new Button();
            lblAnswer = new Label();
            txtAnswer = new TextBox();
            btnGradeAnswer = new Button();
            lblGradeOutput = new Label();
            lblGrade = new Label();
            lblcurrentQuestion = new Label();
            lblCurrentQuestionOutput = new Label();
            ((System.ComponentModel.ISupportInitialize)nudTotalQuestions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaximum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinimum).BeginInit();
            SuspendLayout();
            // 
            // lblTotalQuestions
            // 
            lblTotalQuestions.AutoSize = true;
            lblTotalQuestions.Location = new Point(14, 9);
            lblTotalQuestions.Margin = new Padding(5, 0, 5, 0);
            lblTotalQuestions.Name = "lblTotalQuestions";
            lblTotalQuestions.Size = new Size(412, 25);
            lblTotalQuestions.TabIndex = 0;
            lblTotalQuestions.Text = "How many questions would you like? (10 - 100):";
            // 
            // nudTotalQuestions
            // 
            nudTotalQuestions.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            nudTotalQuestions.Location = new Point(434, 7);
            nudTotalQuestions.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nudTotalQuestions.Name = "nudTotalQuestions";
            nudTotalQuestions.Size = new Size(52, 33);
            nudTotalQuestions.TabIndex = 1;
            nudTotalQuestions.TextAlign = HorizontalAlignment.Right;
            nudTotalQuestions.Value = new decimal(new int[] { 100, 0, 0, 0 });
            nudTotalQuestions.ValueChanged += nudTotalQuestions_ValueChanged;
            // 
            // lblMinimum
            // 
            lblMinimum.AutoSize = true;
            lblMinimum.Location = new Point(14, 48);
            lblMinimum.Margin = new Padding(5, 0, 5, 0);
            lblMinimum.Name = "lblMinimum";
            lblMinimum.Size = new Size(324, 25);
            lblMinimum.TabIndex = 2;
            lblMinimum.Text = "Minimum value for operands? (0 - 9):";
            // 
            // lblMaximum
            // 
            lblMaximum.AutoSize = true;
            lblMaximum.Location = new Point(14, 87);
            lblMaximum.Margin = new Padding(5, 0, 5, 0);
            lblMaximum.Name = "lblMaximum";
            lblMaximum.Size = new Size(327, 25);
            lblMaximum.TabIndex = 4;
            lblMaximum.Text = "Maximum value for operands? (1 - 9):";
            // 
            // nudMaximum
            // 
            nudMaximum.Location = new Point(434, 85);
            nudMaximum.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            nudMaximum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMaximum.Name = "nudMaximum";
            nudMaximum.Size = new Size(52, 33);
            nudMaximum.TabIndex = 5;
            nudMaximum.TextAlign = HorizontalAlignment.Right;
            nudMaximum.Value = new decimal(new int[] { 9, 0, 0, 0 });
            // 
            // nudMinimum
            // 
            nudMinimum.Location = new Point(434, 46);
            nudMinimum.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            nudMinimum.Name = "nudMinimum";
            nudMinimum.Size = new Size(52, 33);
            nudMinimum.TabIndex = 3;
            nudMinimum.TextAlign = HorizontalAlignment.Right;
            // 
            // lblQuestions
            // 
            lblQuestions.AutoSize = true;
            lblQuestions.Location = new Point(23, 131);
            lblQuestions.Name = "lblQuestions";
            lblQuestions.Size = new Size(100, 25);
            lblQuestions.TabIndex = 6;
            lblQuestions.Text = "Questions:";
            // 
            // lblQuestionsOutput
            // 
            lblQuestionsOutput.BorderStyle = BorderStyle.Fixed3D;
            lblQuestionsOutput.Location = new Point(129, 131);
            lblQuestionsOutput.Name = "lblQuestionsOutput";
            lblQuestionsOutput.Size = new Size(45, 25);
            lblQuestionsOutput.TabIndex = 7;
            lblQuestionsOutput.Text = "10";
            lblQuestionsOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRight
            // 
            lblRight.AutoSize = true;
            lblRight.Location = new Point(206, 131);
            lblRight.Name = "lblRight";
            lblRight.Size = new Size(60, 25);
            lblRight.TabIndex = 8;
            lblRight.Text = "Right:";
            // 
            // lblRightOutput
            // 
            lblRightOutput.BorderStyle = BorderStyle.Fixed3D;
            lblRightOutput.Location = new Point(272, 131);
            lblRightOutput.Name = "lblRightOutput";
            lblRightOutput.Size = new Size(45, 25);
            lblRightOutput.TabIndex = 9;
            lblRightOutput.Text = "0";
            lblRightOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWrong
            // 
            lblWrong.AutoSize = true;
            lblWrong.Location = new Point(349, 131);
            lblWrong.Name = "lblWrong";
            lblWrong.Size = new Size(74, 25);
            lblWrong.TabIndex = 10;
            lblWrong.Text = "Wrong:";
            // 
            // lblWrongOutput
            // 
            lblWrongOutput.BorderStyle = BorderStyle.Fixed3D;
            lblWrongOutput.Location = new Point(429, 131);
            lblWrongOutput.Name = "lblWrongOutput";
            lblWrongOutput.Size = new Size(45, 25);
            lblWrongOutput.TabIndex = 11;
            lblWrongOutput.Text = "0";
            lblWrongOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTakeTest
            // 
            btnTakeTest.Location = new Point(14, 294);
            btnTakeTest.Name = "btnTakeTest";
            btnTakeTest.Size = new Size(180, 60);
            btnTakeTest.TabIndex = 19;
            btnTakeTest.Text = "&Take Test";
            btnTakeTest.UseVisualStyleBackColor = true;
            btnTakeTest.Click += btnTakeTest_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(346, 294);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(140, 60);
            btnExit.TabIndex = 21;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(200, 294);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(140, 60);
            btnReset.TabIndex = 20;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblAnswer
            // 
            lblAnswer.Location = new Point(102, 231);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(80, 33);
            lblAnswer.TabIndex = 16;
            lblAnswer.Text = "Answer:";
            lblAnswer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(188, 231);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(94, 33);
            txtAnswer.TabIndex = 17;
            // 
            // btnGradeAnswer
            // 
            btnGradeAnswer.Location = new Point(288, 216);
            btnGradeAnswer.Name = "btnGradeAnswer";
            btnGradeAnswer.Size = new Size(150, 60);
            btnGradeAnswer.TabIndex = 18;
            btnGradeAnswer.Text = "&Grade Answer";
            btnGradeAnswer.UseVisualStyleBackColor = true;
            btnGradeAnswer.Click += btnGradeAnswer_Click;
            // 
            // lblGradeOutput
            // 
            lblGradeOutput.BorderStyle = BorderStyle.Fixed3D;
            lblGradeOutput.Location = new Point(371, 177);
            lblGradeOutput.Name = "lblGradeOutput";
            lblGradeOutput.Size = new Size(67, 25);
            lblGradeOutput.TabIndex = 15;
            lblGradeOutput.Text = "100%";
            lblGradeOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(298, 177);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(67, 25);
            lblGrade.TabIndex = 14;
            lblGrade.Text = "Grade:";
            // 
            // lblcurrentQuestion
            // 
            lblcurrentQuestion.Location = new Point(52, 177);
            lblcurrentQuestion.Name = "lblcurrentQuestion";
            lblcurrentQuestion.Size = new Size(130, 25);
            lblcurrentQuestion.TabIndex = 12;
            lblcurrentQuestion.Text = "Question 1:";
            lblcurrentQuestion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCurrentQuestionOutput
            // 
            lblCurrentQuestionOutput.BorderStyle = BorderStyle.Fixed3D;
            lblCurrentQuestionOutput.Location = new Point(188, 177);
            lblCurrentQuestionOutput.Name = "lblCurrentQuestionOutput";
            lblCurrentQuestionOutput.Size = new Size(94, 25);
            lblCurrentQuestionOutput.TabIndex = 13;
            lblCurrentQuestionOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmElementaryMathTestGui
            // 
            AcceptButton = btnTakeTest;
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(498, 374);
            Controls.Add(lblCurrentQuestionOutput);
            Controls.Add(lblcurrentQuestion);
            Controls.Add(lblGradeOutput);
            Controls.Add(lblGrade);
            Controls.Add(btnGradeAnswer);
            Controls.Add(txtAnswer);
            Controls.Add(lblAnswer);
            Controls.Add(btnReset);
            Controls.Add(btnExit);
            Controls.Add(btnTakeTest);
            Controls.Add(lblWrongOutput);
            Controls.Add(lblWrong);
            Controls.Add(lblRightOutput);
            Controls.Add(lblRight);
            Controls.Add(lblQuestionsOutput);
            Controls.Add(lblQuestions);
            Controls.Add(nudMinimum);
            Controls.Add(nudMaximum);
            Controls.Add(lblMaximum);
            Controls.Add(lblMinimum);
            Controls.Add(nudTotalQuestions);
            Controls.Add(lblTotalQuestions);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "frmElementaryMathTestGui";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Elementary Math Test";
            ((System.ComponentModel.ISupportInitialize)nudTotalQuestions).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaximum).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinimum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalQuestions;
        private NumericUpDown nudTotalQuestions;
        private Label lblMinimum;
        private Label lblMaximum;
        private NumericUpDown nudMaximum;
        private NumericUpDown nudMinimum;
        private Label lblQuestions;
        private Label lblQuestionsOutput;
        private Label lblRight;
        private Label lblRightOutput;
        private Label lblWrong;
        private Label lblWrongOutput;
        private Button btnTakeTest;
        private Button btnExit;
        private Button btnReset;
        private Label lblAnswer;
        private TextBox txtAnswer;
        private Button btnGradeAnswer;
        private Label lblGradeOutput;
        private Label lblGrade;
        private Label lblcurrentQuestion;
        private Label lblCurrentQuestionOutput;
    }
}
