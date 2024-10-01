namespace BMIGUI
{
    partial class BMIGUI
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
            groupBox1 = new GroupBox();
            MetricRadioButton = new RadioButton();
            ImperialRadioButton = new RadioButton();
            groupBox2 = new GroupBox();
            WeightUnitLabel = new Label();
            HeightUnitLabel = new Label();
            WeightTextBox = new TextBox();
            WeightLabel = new Label();
            HeightTextBox = new TextBox();
            HeightLabel = new Label();
            groupBox3 = new GroupBox();
            ResultLabel = new Label();
            CalculateButton = new Button();
            ResetButton = new Button();
            ExitButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MetricRadioButton);
            groupBox1.Controls.Add(ImperialRadioButton);
            groupBox1.Location = new Point(14, 14);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(289, 88);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Measurement System";
            // 
            // MetricRadioButton
            // 
            MetricRadioButton.AutoSize = true;
            MetricRadioButton.Location = new Point(177, 36);
            MetricRadioButton.Margin = new Padding(5);
            MetricRadioButton.Name = "MetricRadioButton";
            MetricRadioButton.Size = new Size(84, 29);
            MetricRadioButton.TabIndex = 1;
            MetricRadioButton.TabStop = true;
            MetricRadioButton.Text = "&Metric";
            MetricRadioButton.UseVisualStyleBackColor = true;
            MetricRadioButton.CheckedChanged += MetricRadioButton_CheckedChanged;
            // 
            // ImperialRadioButton
            // 
            ImperialRadioButton.AutoSize = true;
            ImperialRadioButton.Location = new Point(10, 36);
            ImperialRadioButton.Margin = new Padding(5);
            ImperialRadioButton.Name = "ImperialRadioButton";
            ImperialRadioButton.Size = new Size(99, 29);
            ImperialRadioButton.TabIndex = 0;
            ImperialRadioButton.TabStop = true;
            ImperialRadioButton.Text = "&Imperial";
            ImperialRadioButton.UseVisualStyleBackColor = true;
            ImperialRadioButton.CheckedChanged += ImperialRadioButton_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(WeightUnitLabel);
            groupBox2.Controls.Add(HeightUnitLabel);
            groupBox2.Controls.Add(WeightTextBox);
            groupBox2.Controls.Add(WeightLabel);
            groupBox2.Controls.Add(HeightTextBox);
            groupBox2.Controls.Add(HeightLabel);
            groupBox2.Location = new Point(14, 112);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(289, 142);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Measurements";
            // 
            // WeightUnitLabel
            // 
            WeightUnitLabel.AutoSize = true;
            WeightUnitLabel.Location = new Point(245, 84);
            WeightUnitLabel.Name = "WeightUnitLabel";
            WeightUnitLabel.Size = new Size(36, 25);
            WeightUnitLabel.TabIndex = 5;
            WeightUnitLabel.Text = "lbs";
            // 
            // HeightUnitLabel
            // 
            HeightUnitLabel.AutoSize = true;
            HeightUnitLabel.Location = new Point(245, 50);
            HeightUnitLabel.Name = "HeightUnitLabel";
            HeightUnitLabel.Size = new Size(28, 25);
            HeightUnitLabel.TabIndex = 4;
            HeightUnitLabel.Text = "in";
            // 
            // WeightTextBox
            // 
            WeightTextBox.Location = new Point(88, 81);
            WeightTextBox.Name = "WeightTextBox";
            WeightTextBox.Size = new Size(151, 33);
            WeightTextBox.TabIndex = 3;
            // 
            // WeightLabel
            // 
            WeightLabel.AutoSize = true;
            WeightLabel.Location = new Point(10, 84);
            WeightLabel.Name = "WeightLabel";
            WeightLabel.Size = new Size(76, 25);
            WeightLabel.TabIndex = 2;
            WeightLabel.Text = "&Weight:";
            // 
            // HeightTextBox
            // 
            HeightTextBox.Location = new Point(88, 42);
            HeightTextBox.Name = "HeightTextBox";
            HeightTextBox.Size = new Size(151, 33);
            HeightTextBox.TabIndex = 1;
            // 
            // HeightLabel
            // 
            HeightLabel.AutoSize = true;
            HeightLabel.Location = new Point(10, 45);
            HeightLabel.Name = "HeightLabel";
            HeightLabel.Size = new Size(72, 25);
            HeightLabel.TabIndex = 0;
            HeightLabel.Text = "&Height:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ResultLabel);
            groupBox3.Location = new Point(14, 264);
            groupBox3.Margin = new Padding(5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5);
            groupBox3.Size = new Size(289, 167);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Result";
            // 
            // ResultLabel
            // 
            ResultLabel.BorderStyle = BorderStyle.Fixed3D;
            ResultLabel.Location = new Point(18, 31);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(263, 117);
            ResultLabel.TabIndex = 0;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(14, 439);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(127, 52);
            CalculateButton.TabIndex = 2;
            CalculateButton.Text = "&Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(147, 439);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(75, 52);
            ResetButton.TabIndex = 3;
            ResetButton.Text = "&Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(228, 439);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 52);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // BMIGUI
            // 
            AcceptButton = CalculateButton;
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ExitButton;
            ClientSize = new Size(330, 534);
            Controls.Add(ExitButton);
            Controls.Add(ResetButton);
            Controls.Add(CalculateButton);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "BMIGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BMI Calculator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton MetricRadioButton;
        private RadioButton ImperialRadioButton;
        private GroupBox groupBox2;
        private Label WeightUnitLabel;
        private Label HeightUnitLabel;
        private TextBox WeightTextBox;
        private Label WeightLabel;
        private TextBox HeightTextBox;
        private Label HeightLabel;
        private GroupBox groupBox3;
        private Label ResultLabel;
        private Button CalculateButton;
        private Button ResetButton;
        private Button ExitButton;
    }
}
