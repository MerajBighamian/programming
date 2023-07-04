namespace sodoku_solver_windows_form
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
            textBoxSolution = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxSolution
            // 
            textBoxSolution.Location = new Point(12, 12);
            textBoxSolution.Multiline = true;
            textBoxSolution.Name = "textBoxSolution";
            textBoxSolution.Size = new Size(198, 167);
            textBoxSolution.TabIndex = 0;
            textBoxSolution.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(56, 221);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "solve";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonSolve_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBoxSolution);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSolution;
        private Button button1;
    }
}