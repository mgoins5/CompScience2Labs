namespace Numbering_System_Converter
{
    partial class frmNumberingSystemConverter3000
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
            btnConvert = new Button();
            grpConverter = new GroupBox();
            cmbToBase = new ComboBox();
            lblToBase = new Label();
            lblToOutput = new Label();
            lblTo = new Label();
            cmbFromBase = new ComboBox();
            lblFromBase = new Label();
            txtFrom = new TextBox();
            lblFrom = new Label();
            btnReset = new Button();
            btnExit = new Button();
            grpConverter.SuspendLayout();
            SuspendLayout();
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(19, 204);
            btnConvert.Margin = new Padding(5);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(186, 55);
            btnConvert.TabIndex = 1;
            btnConvert.Text = "&Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // grpConverter
            // 
            grpConverter.Controls.Add(cmbToBase);
            grpConverter.Controls.Add(lblToBase);
            grpConverter.Controls.Add(lblToOutput);
            grpConverter.Controls.Add(lblTo);
            grpConverter.Controls.Add(cmbFromBase);
            grpConverter.Controls.Add(lblFromBase);
            grpConverter.Controls.Add(txtFrom);
            grpConverter.Controls.Add(lblFrom);
            grpConverter.Location = new Point(19, 20);
            grpConverter.Margin = new Padding(5);
            grpConverter.Name = "grpConverter";
            grpConverter.Padding = new Padding(5);
            grpConverter.Size = new Size(386, 174);
            grpConverter.TabIndex = 0;
            grpConverter.TabStop = false;
            // 
            // cmbToBase
            // 
            cmbToBase.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbToBase.FormattingEnabled = true;
            cmbToBase.Location = new Point(305, 101);
            cmbToBase.Margin = new Padding(5);
            cmbToBase.MaxDropDownItems = 9;
            cmbToBase.Name = "cmbToBase";
            cmbToBase.Size = new Size(68, 33);
            cmbToBase.TabIndex = 7;
            cmbToBase.SelectedIndexChanged += cmbFromBase_SelectedIndexChanged;
            // 
            // lblToBase
            // 
            lblToBase.AutoSize = true;
            lblToBase.Location = new Point(244, 104);
            lblToBase.Margin = new Padding(5, 0, 5, 0);
            lblToBase.Name = "lblToBase";
            lblToBase.Size = new Size(51, 25);
            lblToBase.TabIndex = 6;
            lblToBase.Text = "base";
            // 
            // lblToOutput
            // 
            lblToOutput.BorderStyle = BorderStyle.Fixed3D;
            lblToOutput.Location = new Point(79, 97);
            lblToOutput.Margin = new Padding(5, 0, 5, 0);
            lblToOutput.Name = "lblToOutput";
            lblToOutput.Size = new Size(157, 38);
            lblToOutput.TabIndex = 5;
            lblToOutput.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(34, 104);
            lblTo.Margin = new Padding(5, 0, 5, 0);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(35, 25);
            lblTo.TabIndex = 4;
            lblTo.Text = "To:";
            lblTo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbFromBase
            // 
            cmbFromBase.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFromBase.FormattingEnabled = true;
            cmbFromBase.Location = new Point(305, 53);
            cmbFromBase.Margin = new Padding(5);
            cmbFromBase.MaxDropDownItems = 9;
            cmbFromBase.Name = "cmbFromBase";
            cmbFromBase.Size = new Size(68, 33);
            cmbFromBase.TabIndex = 3;
            cmbFromBase.SelectedIndexChanged += cmbFromBase_SelectedIndexChanged;
            // 
            // lblFromBase
            // 
            lblFromBase.AutoSize = true;
            lblFromBase.Location = new Point(244, 56);
            lblFromBase.Margin = new Padding(5, 0, 5, 0);
            lblFromBase.Name = "lblFromBase";
            lblFromBase.Size = new Size(51, 25);
            lblFromBase.TabIndex = 2;
            lblFromBase.Text = "base";
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(79, 53);
            txtFrom.Margin = new Padding(5);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(155, 33);
            txtFrom.TabIndex = 1;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(10, 56);
            lblFrom.Margin = new Padding(5, 0, 5, 0);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(59, 25);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "From:";
            lblFrom.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(215, 204);
            btnReset.Margin = new Padding(5);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(90, 55);
            btnReset.TabIndex = 2;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(315, 204);
            btnExit.Margin = new Padding(5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 55);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmNumberingSystemConverter3000
            // 
            AcceptButton = btnConvert;
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(421, 278);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(grpConverter);
            Controls.Add(btnConvert);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "frmNumberingSystemConverter3000";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Numbering System Converter 3000";
            Load += frmNumberingSystemConverter3000_Load;
            grpConverter.ResumeLayout(false);
            grpConverter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnConvert;
        private GroupBox grpConverter;
        private Label lblFromBase;
        private TextBox txtFrom;
        private Label lblFrom;
        private Button btnReset;
        private Button btnExit;
        private ComboBox cmbToBase;
        private Label lblToBase;
        private Label lblToOutput;
        private Label lblTo;
        private ComboBox cmbFromBase;
    }
}
