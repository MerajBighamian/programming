namespace simple_calculator
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
            reset = new Button();
            txtSymbol = new TextBox();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            calculate = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // reset
            // 
            reset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            reset.Location = new Point(97, 151);
            reset.Name = "reset";
            reset.Size = new Size(128, 38);
            reset.TabIndex = 0;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += btnReset;
            // 
            // txtSymbol
            // 
            txtSymbol.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSymbol.Location = new Point(185, 59);
            txtSymbol.Name = "txtSymbol";
            txtSymbol.Size = new Size(57, 27);
            txtSymbol.TabIndex = 1;
            txtSymbol.TextChanged += textBox1_TextChanged;
            // 
            // txtNum1
            // 
            txtNum1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtNum1.Location = new Point(37, 59);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(125, 27);
            txtNum1.TabIndex = 2;
            txtNum1.TextChanged += textBox2_TextChanged;
            // 
            // txtNum2
            // 
            txtNum2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtNum2.Location = new Point(264, 59);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(125, 27);
            txtNum2.TabIndex = 3;
            txtNum2.TextChanged += textBox3_TextChanged;
            // 
            // calculate
            // 
            calculate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            calculate.Location = new Point(286, 151);
            calculate.Name = "calculate";
            calculate.Size = new Size(128, 38);
            calculate.TabIndex = 4;
            calculate.Text = "Calculate";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += btnCalculate;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(413, 62);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(19, 20);
            lblResult.TabIndex = 5;
            lblResult.Text = "=";
            lblResult.Click += btnCalculate;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 260);
            Controls.Add(lblResult);
            Controls.Add(calculate);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(txtSymbol);
            Controls.Add(reset);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button reset;
        private TextBox txtSymbol;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Button calculate;
        private Label lblResult;
    }
}