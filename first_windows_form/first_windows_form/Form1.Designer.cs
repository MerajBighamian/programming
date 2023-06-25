namespace first_windows_form
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
            button1 = new Button();
            label1 = new Label();
            text_Name = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Family = new Label();
            text_Age = new TextBox();
            text_Family = new TextBox();
            text_Address = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(396, 253);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(132, 40);
            button1.TabIndex = 0;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(276, 46);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // text_Name
            // 
            text_Name.Location = new Point(334, 43);
            text_Name.Margin = new Padding(3, 2, 3, 2);
            text_Name.Name = "text_Name";
            text_Name.Size = new Size(248, 23);
            text_Name.TabIndex = 1;
            text_Name.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 201);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 151);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 4;
            label3.Text = "Age";
            label3.Click += label3_Click;
            // 
            // Family
            // 
            Family.AutoSize = true;
            Family.Location = new Point(277, 102);
            Family.Name = "Family";
            Family.Size = new Size(42, 15);
            Family.TabIndex = 5;
            Family.Text = "Family";
            Family.Click += label4_Click;
            // 
            // text_Age
            // 
            text_Age.Location = new Point(334, 143);
            text_Age.Name = "text_Age";
            text_Age.Size = new Size(248, 23);
            text_Age.TabIndex = 6;
            text_Age.TextChanged += textBox1_TextChanged_1;
            // 
            // text_Family
            // 
            text_Family.Location = new Point(334, 94);
            text_Family.Name = "text_Family";
            text_Family.Size = new Size(248, 23);
            text_Family.TabIndex = 7;
            // 
            // text_Address
            // 
            text_Address.Location = new Point(334, 193);
            text_Address.Name = "text_Address";
            text_Address.Size = new Size(248, 23);
            text_Address.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 448);
            Controls.Add(text_Address);
            Controls.Add(text_Family);
            Controls.Add(text_Age);
            Controls.Add(Family);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(text_Name);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox text_Name;
        private Label label2;
        private Label label3;
        private Label Family;
        private TextBox text_Age;
        private TextBox text_Family;
        private TextBox text_Address;
    }
}