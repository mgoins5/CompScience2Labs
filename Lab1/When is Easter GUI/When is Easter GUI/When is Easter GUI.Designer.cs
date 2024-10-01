namespace When_is_Easter_GUI
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            YearTextBox = new TextBox();
            label2 = new Label();
            OutputLabel = new Label();
            CalculateButton = new Button();
            ExitButton = new Button();
            panel1 = new Panel();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 20);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 1;
            label1.Text = "Year:";
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(84, 17);
            YearTextBox.Margin = new Padding(5);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(357, 32);
            YearTextBox.TabIndex = 2;
            toolTip1.SetToolTip(YearTextBox, "User inputs a year to see what day Easter falls on.");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 70);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 3;
            label2.Text = "Easter:";
            // 
            // OutputLabel
            // 
            OutputLabel.BorderStyle = BorderStyle.Fixed3D;
            OutputLabel.ImageAlign = ContentAlignment.TopLeft;
            OutputLabel.Location = new Point(84, 63);
            OutputLabel.Margin = new Padding(5, 0, 5, 0);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(357, 38);
            OutputLabel.TabIndex = 4;
            OutputLabel.TextAlign = ContentAlignment.MiddleLeft;
            toolTip1.SetToolTip(OutputLabel, "Displays the month and day for the given year.");
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(94, 220);
            CalculateButton.Margin = new Padding(5);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(284, 73);
            CalculateButton.TabIndex = 5;
            CalculateButton.Text = "&Calculate";
            toolTip1.SetToolTip(CalculateButton, "Calulates the day for the given year.");
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(388, 220);
            ExitButton.Margin = new Padding(5);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(165, 73);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "E&xit";
            toolTip1.SetToolTip(ExitButton, "Quits the application.");
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(YearTextBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(OutputLabel);
            panel1.Location = new Point(94, 92);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 118);
            panel1.TabIndex = 0;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 200;
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 200;
            toolTip1.ReshowDelay = 40;
            // 
            // Form1
            // 
            AcceptButton = CalculateButton;
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ExitButton;
            ClientSize = new Size(664, 397);
            Controls.Add(panel1);
            Controls.Add(ExitButton);
            Controls.Add(CalculateButton);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "When is Easter?";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox YearTextBox;
        private Label label2;
        private Label OutputLabel;
        private Button CalculateButton;
        private Button ExitButton;
        private Panel panel1;
        private ToolTip toolTip1;
    }
}
