namespace projetao
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
            bt1 = new Button();
            bt2 = new Button();
            bt3 = new Button();
            bt6 = new Button();
            bt5 = new Button();
            bt4 = new Button();
            bt9 = new Button();
            bt8 = new Button();
            bt7 = new Button();
            btSub = new Button();
            btSum = new Button();
            btDiv = new Button();
            btMult = new Button();
            btEqual = new Button();
            bt0 = new Button();
            btDot = new Button();
            btReset = new Button();
            tbResult = new TextBox();
            SuspendLayout();
            // 
            // bt1
            // 
            bt1.Location = new Point(12, 265);
            bt1.Name = "bt1";
            bt1.Size = new Size(64, 64);
            bt1.TabIndex = 0;
            bt1.Text = "1";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += btDigit_Click;
            // 
            // bt2
            // 
            bt2.Location = new Point(82, 265);
            bt2.Name = "bt2";
            bt2.Size = new Size(64, 64);
            bt2.TabIndex = 1;
            bt2.Text = "2";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += btDigit_Click;
            // 
            // bt3
            // 
            bt3.Location = new Point(152, 265);
            bt3.Name = "bt3";
            bt3.Size = new Size(64, 64);
            bt3.TabIndex = 2;
            bt3.Text = "3";
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += btDigit_Click;
            // 
            // bt6
            // 
            bt6.Location = new Point(152, 195);
            bt6.Name = "bt6";
            bt6.Size = new Size(64, 64);
            bt6.TabIndex = 5;
            bt6.Text = "6";
            bt6.UseVisualStyleBackColor = true;
            bt6.Click += btDigit_Click;
            // 
            // bt5
            // 
            bt5.Location = new Point(82, 195);
            bt5.Name = "bt5";
            bt5.Size = new Size(64, 64);
            bt5.TabIndex = 4;
            bt5.Text = "5";
            bt5.UseVisualStyleBackColor = true;
            bt5.Click += btDigit_Click;
            // 
            // bt4
            // 
            bt4.Location = new Point(12, 195);
            bt4.Name = "bt4";
            bt4.Size = new Size(64, 64);
            bt4.TabIndex = 3;
            bt4.Text = "4";
            bt4.UseVisualStyleBackColor = true;
            bt4.Click += btDigit_Click;
            // 
            // bt9
            // 
            bt9.Location = new Point(152, 125);
            bt9.Name = "bt9";
            bt9.Size = new Size(64, 64);
            bt9.TabIndex = 8;
            bt9.Text = "9";
            bt9.UseVisualStyleBackColor = true;
            bt9.Click += btDigit_Click;
            // 
            // bt8
            // 
            bt8.Location = new Point(82, 125);
            bt8.Name = "bt8";
            bt8.Size = new Size(64, 64);
            bt8.TabIndex = 7;
            bt8.Text = "8";
            bt8.UseVisualStyleBackColor = true;
            bt8.Click += btDigit_Click;
            // 
            // bt7
            // 
            bt7.Location = new Point(12, 125);
            bt7.Name = "bt7";
            bt7.Size = new Size(64, 64);
            bt7.TabIndex = 6;
            bt7.Text = "7";
            bt7.UseVisualStyleBackColor = true;
            bt7.Click += btDigit_Click;
            // 
            // btSub
            // 
            btSub.BackColor = SystemColors.InactiveCaption;
            btSub.Location = new Point(222, 265);
            btSub.Name = "btSub";
            btSub.Size = new Size(64, 64);
            btSub.TabIndex = 11;
            btSub.Text = "-";
            btSub.UseVisualStyleBackColor = false;
            btSub.Click += btOperation_Click;
            // 
            // btSum
            // 
            btSum.BackColor = SystemColors.InactiveCaption;
            btSum.Location = new Point(222, 335);
            btSum.Name = "btSum";
            btSum.Size = new Size(64, 64);
            btSum.TabIndex = 10;
            btSum.Text = "+";
            btSum.UseVisualStyleBackColor = false;
            btSum.Click += btOperation_Click;
            // 
            // btDiv
            // 
            btDiv.BackColor = SystemColors.InactiveCaption;
            btDiv.Location = new Point(222, 125);
            btDiv.Name = "btDiv";
            btDiv.Size = new Size(64, 64);
            btDiv.TabIndex = 13;
            btDiv.Text = "/";
            btDiv.UseVisualStyleBackColor = false;
            btDiv.Click += btOperation_Click;
            // 
            // btMult
            // 
            btMult.BackColor = SystemColors.InactiveCaption;
            btMult.Location = new Point(222, 195);
            btMult.Name = "btMult";
            btMult.Size = new Size(64, 64);
            btMult.TabIndex = 12;
            btMult.Text = "x";
            btMult.UseVisualStyleBackColor = false;
            btMult.Click += btOperation_Click;
            // 
            // btEqual
            // 
            btEqual.BackColor = SystemColors.InactiveCaption;
            btEqual.Location = new Point(152, 335);
            btEqual.Name = "btEqual";
            btEqual.Size = new Size(64, 64);
            btEqual.TabIndex = 15;
            btEqual.Text = "=";
            btEqual.UseVisualStyleBackColor = false;
            btEqual.Click += btEqual_Click;
            // 
            // bt0
            // 
            bt0.Location = new Point(82, 335);
            bt0.Name = "bt0";
            bt0.Size = new Size(64, 64);
            bt0.TabIndex = 17;
            bt0.Text = "0";
            bt0.UseVisualStyleBackColor = true;
            bt0.Click += btDigit_Click;
            // 
            // btDot
            // 
            btDot.BackColor = SystemColors.InactiveCaption;
            btDot.Location = new Point(12, 335);
            btDot.Name = "btDot";
            btDot.Size = new Size(64, 64);
            btDot.TabIndex = 18;
            btDot.Text = ".";
            btDot.UseVisualStyleBackColor = false;
            btDot.Click += btDigit_Click;
            // 
            // btReset
            // 
            btReset.BackColor = SystemColors.ActiveCaption;
            btReset.Location = new Point(222, 89);
            btReset.Name = "btReset";
            btReset.Size = new Size(64, 30);
            btReset.TabIndex = 19;
            btReset.Text = "C";
            btReset.UseVisualStyleBackColor = false;
            // 
            // tbResult
            // 
            tbResult.Location = new Point(12, 21);
            tbResult.Name = "tbResult";
            tbResult.ReadOnly = true;
            tbResult.Size = new Size(274, 23);
            tbResult.TabIndex = 20;
            tbResult.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 407);
            Controls.Add(tbResult);
            Controls.Add(btReset);
            Controls.Add(btDot);
            Controls.Add(bt0);
            Controls.Add(btEqual);
            Controls.Add(btDiv);
            Controls.Add(btMult);
            Controls.Add(btSub);
            Controls.Add(btSum);
            Controls.Add(bt9);
            Controls.Add(bt8);
            Controls.Add(bt7);
            Controls.Add(bt6);
            Controls.Add(bt5);
            Controls.Add(bt4);
            Controls.Add(bt3);
            Controls.Add(bt2);
            Controls.Add(bt1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt1;
        private Button bt2;
        private Button bt3;
        private Button bt6;
        private Button bt5;
        private Button bt4;
        private Button bt9;
        private Button bt8;
        private Button bt7;
        private Button btSub;
        private Button btSum;
        private Button btDiv;
        private Button btMult;
        private Button btEqual;
        private Button bt0;
        private Button btDot;
        private Button btReset;
        private TextBox tbResult;
    }
}
