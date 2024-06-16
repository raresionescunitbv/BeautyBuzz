namespace BeautyBuzz
{
    partial class DetaliiCont
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetaliiCont));
            button1 = new PictureBox();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)button1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(3, 2);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(35, 29);
            button1.TabIndex = 18;
            button1.TabStop = false;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(323, 97);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(407, 119);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DodgerBlue;
            label7.Location = new Point(194, 439);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 16;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(194, 365);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 15;
            label6.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DodgerBlue;
            label5.Location = new Point(194, 301);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 14;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(51, 439);
            label4.Name = "label4";
            label4.Size = new Size(63, 26);
            label4.TabIndex = 13;
            label4.Text = "Mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(45, 365);
            label3.Name = "label3";
            label3.Size = new Size(112, 26);
            label3.TabIndex = 12;
            label3.Text = "Prenume:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(45, 301);
            label2.Name = "label2";
            label2.Size = new Size(82, 26);
            label2.TabIndex = 11;
            label2.Text = "Nume:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(51, 243);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 10;
            label1.Text = "Detalii cont";
            // 
            // DetaliiCont
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DetaliiCont";
            Size = new Size(850, 667);
            ((System.ComponentModel.ISupportInitialize)button1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox button1;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
