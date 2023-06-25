namespace Advance_Calculator
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
            btn6 = new Button();
            btn4 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn0 = new Button();
            btn5 = new Button();
            btn9 = new Button();
            btnClear = new Button();
            btnEqual = new Button();
            btn3 = new Button();
            btn2 = new Button();
            button12 = new Button();
            txtBox = new TextBox();
            btnAdd = new Button();
            btnMultiply = new Button();
            btnMines = new Button();
            btnDivide = new Button();
            btnPower = new Button();
            btnMandeh = new Button();
            SuspendLayout();
            // 
            // btn6
            // 
            btn6.Location = new Point(244, 313);
            btn6.Name = "btn6";
            btn6.Size = new Size(102, 47);
            btn6.TabIndex = 0;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += n6_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(8, 313);
            btn4.Name = "btn4";
            btn4.Size = new Size(102, 47);
            btn4.TabIndex = 1;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += n4_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(8, 388);
            btn7.Name = "btn7";
            btn7.Size = new Size(102, 47);
            btn7.TabIndex = 2;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += n7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(125, 388);
            btn8.Name = "btn8";
            btn8.Size = new Size(102, 48);
            btn8.TabIndex = 3;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += n8_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(125, 463);
            btn0.Name = "btn0";
            btn0.Size = new Size(102, 48);
            btn0.TabIndex = 4;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += n0_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(125, 313);
            btn5.Name = "btn5";
            btn5.Size = new Size(102, 47);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += n5_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(244, 388);
            btn9.Name = "btn9";
            btn9.Size = new Size(102, 48);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += n9_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(8, 463);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(102, 48);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += nClear_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(244, 463);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(102, 48);
            btnEqual.TabIndex = 8;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += nEqual_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(244, 250);
            btn3.Name = "btn3";
            btn3.Size = new Size(102, 41);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += n3_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(125, 250);
            btn2.Name = "btn2";
            btn2.Size = new Size(102, 41);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += n2_Click;
            // 
            // button12
            // 
            button12.Location = new Point(8, 250);
            button12.Name = "button12";
            button12.Size = new Size(102, 41);
            button12.TabIndex = 11;
            button12.Text = "1";
            button12.UseVisualStyleBackColor = true;
            button12.Click += n1_Click;
            // 
            // txtBox
            // 
            txtBox.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtBox.Location = new Point(8, 12);
            txtBox.Multiline = true;
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(338, 90);
            txtBox.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(8, 187);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 41);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += nAdd_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(125, 187);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(102, 41);
            btnMultiply.TabIndex = 14;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += nMultiply_Click;
            // 
            // btnMines
            // 
            btnMines.Location = new Point(244, 187);
            btnMines.Name = "btnMines";
            btnMines.Size = new Size(102, 41);
            btnMines.TabIndex = 15;
            btnMines.Text = "-";
            btnMines.UseVisualStyleBackColor = true;
            btnMines.Click += nMines_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(8, 125);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(102, 41);
            btnDivide.TabIndex = 16;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += nDivide_Click;
            // 
            // btnPower
            // 
            btnPower.Location = new Point(125, 125);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(102, 41);
            btnPower.TabIndex = 17;
            btnPower.Text = "**";
            btnPower.UseVisualStyleBackColor = true;
            btnPower.Click += nPower_Click;
            // 
            // btnMandeh
            // 
            btnMandeh.Location = new Point(244, 125);
            btnMandeh.Name = "btnMandeh";
            btnMandeh.Size = new Size(102, 41);
            btnMandeh.TabIndex = 18;
            btnMandeh.Text = "%";
            btnMandeh.UseVisualStyleBackColor = true;
            btnMandeh.Click += nMandeh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 542);
            Controls.Add(btnMandeh);
            Controls.Add(btnPower);
            Controls.Add(btnDivide);
            Controls.Add(btnMines);
            Controls.Add(btnMultiply);
            Controls.Add(btnAdd);
            Controls.Add(txtBox);
            Controls.Add(button12);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btnEqual);
            Controls.Add(btnClear);
            Controls.Add(btn9);
            Controls.Add(btn5);
            Controls.Add(btn0);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn4);
            Controls.Add(btn6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn6;
        private Button btn4;
        private Button btn7;
        private Button btn8;
        private Button btn0;
        private Button btn5;
        private Button btn9;
        private Button btnClear;
        private Button btnEqual;
        private Button btn3;
        private Button btn2;
        private Button button12;
        private TextBox txtBox;
        private Button btnAdd;
        private Button btnMultiply;
        private Button btnMines;
        private Button btnDivide;
        private Button btnPower;
        private Button btnMandeh;
    }
}