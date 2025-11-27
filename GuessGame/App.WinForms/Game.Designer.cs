namespace App.WinForms
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            labelTry = new Label();
            label6 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, -4);
            label1.Name = "label1";
            label1.Size = new Size(344, 52);
            label1.TabIndex = 0;
            label1.Text = "Guess a number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(24, 103);
            label2.Name = "label2";
            label2.Size = new Size(198, 29);
            label2.TabIndex = 1;
            label2.Text = "Choode a range";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(403, 103);
            label3.Name = "label3";
            label3.Size = new Size(141, 29);
            label3.TabIndex = 2;
            label3.Text = "Try to guess";
            label3.Click += label3_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(79, 148);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(70, 27);
            numericUpDown2.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(205, 148);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(70, 27);
            numericUpDown1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(24, 154);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 6;
            label4.Text = "from";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.Location = new Point(169, 154);
            label5.Name = "label5";
            label5.Size = new Size(30, 21);
            label5.TabIndex = 7;
            label5.Text = "to";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(96, 130, 182);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(24, 196);
            button1.Name = "button1";
            button1.Size = new Size(251, 29);
            button1.TabIndex = 8;
            button1.Text = "Generate a number";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(96, 130, 182);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(589, 245);
            button2.Name = "button2";
            button2.Size = new Size(217, 44);
            button2.TabIndex = 9;
            button2.Text = "Take a guess";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(358, 147);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(448, 78);
            textBox1.TabIndex = 10;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // labelTry
            // 
            labelTry.AutoSize = true;
            labelTry.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTry.Location = new Point(694, 124);
            labelTry.Name = "labelTry";
            labelTry.Size = new Size(112, 20);
            labelTry.TabIndex = 11;
            labelTry.Text = "5 attempts left";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(751, 66);
            label6.Name = "label6";
            label6.Size = new Size(55, 28);
            label6.TabIndex = 12;
            label6.Text = "🔥 0";
            label6.Click += label6_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(96, 130, 182);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(24, 260);
            button3.Name = "button3";
            button3.Size = new Size(147, 29);
            button3.TabIndex = 13;
            button3.Text = "finish the game";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 320);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(labelTry);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numericUpDown1);
            Controls.Add(numericUpDown2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Game";
            Text = "Game";
            Load += Game_Load;
            Paint += Game_Paint;
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label labelTry;
        private Label label6;
        private Button button3;
    }
}