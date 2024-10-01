namespace CoinFlipSimulatorGUI
{
    partial class CoinFlipSimulatorGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoinFlipSimulatorGUI));
            groupBox1 = new GroupBox();
            TailsLabel = new Label();
            HeadsLabel = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            FlipButton = new Button();
            ValueNumUpDown = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ValueNumUpDown).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TailsLabel);
            groupBox1.Controls.Add(HeadsLabel);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(34, 37);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(467, 308);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Results";
            // 
            // TailsLabel
            // 
            TailsLabel.BorderStyle = BorderStyle.Fixed3D;
            TailsLabel.Location = new Point(250, 194);
            TailsLabel.Margin = new Padding(5, 0, 5, 0);
            TailsLabel.Name = "TailsLabel";
            TailsLabel.Size = new Size(174, 70);
            TailsLabel.TabIndex = 1;
            TailsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HeadsLabel
            // 
            HeadsLabel.BorderStyle = BorderStyle.Fixed3D;
            HeadsLabel.Location = new Point(39, 194);
            HeadsLabel.Margin = new Padding(5, 0, 5, 0);
            HeadsLabel.Name = "HeadsLabel";
            HeadsLabel.Size = new Size(174, 70);
            HeadsLabel.TabIndex = 0;
            HeadsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(250, 36);
            pictureBox2.Margin = new Padding(5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(174, 153);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 36);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FlipButton
            // 
            FlipButton.Location = new Point(34, 353);
            FlipButton.Name = "FlipButton";
            FlipButton.Size = new Size(324, 70);
            FlipButton.TabIndex = 0;
            FlipButton.Text = "&Flip";
            FlipButton.UseVisualStyleBackColor = true;
            FlipButton.Click += button1_Click;
            // 
            // ValueNumUpDown
            // 
            ValueNumUpDown.Font = new Font("Segoe UI", 35.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ValueNumUpDown.Location = new Point(379, 353);
            ValueNumUpDown.Margin = new Padding(77, 103, 77, 103);
            ValueNumUpDown.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            ValueNumUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ValueNumUpDown.Name = "ValueNumUpDown";
            ValueNumUpDown.Size = new Size(122, 70);
            ValueNumUpDown.TabIndex = 1;
            ValueNumUpDown.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // CoinFlipSimulatorGUI
            // 
            AcceptButton = FlipButton;
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(534, 461);
            Controls.Add(ValueNumUpDown);
            Controls.Add(FlipButton);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "CoinFlipSimulatorGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coin Flip Simulator GUI";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ValueNumUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label HeadsLabel;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label TailsLabel;
        private Button FlipButton;
        private NumericUpDown ValueNumUpDown;
    }
}
