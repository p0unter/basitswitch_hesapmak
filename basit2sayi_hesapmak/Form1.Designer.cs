namespace basit2sayi_hesapmak
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 34);
            label1.Name = "label1";
            label1.Size = new Size(75, 30);
            label1.TabIndex = 0;
            label1.Text = "Sayı1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 100);
            label2.Name = "label2";
            label2.Size = new Size(76, 30);
            label2.TabIndex = 1;
            label2.Text = "Sayı2";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 37);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(166, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 37);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(15, 236);
            button1.Name = "button1";
            button1.Size = new Size(323, 55);
            button1.TabIndex = 4;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(100, 310);
            label3.Name = "label3";
            label3.Size = new Size(108, 30);
            label3.TabIndex = 5;
            label3.Text = "(Sonuç)";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(126, 165);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 37);
            textBox3.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 347);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(7, 5, 7, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label3;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox3;
    }
}