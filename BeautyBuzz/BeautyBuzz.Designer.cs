namespace BeautyBuzz
{
    partial class BeautyBuzz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeautyBuzz));
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(692, 106);
            label1.Name = "label1";
            label1.Size = new Size(486, 50);
            label1.TabIndex = 0;
            label1.Text = "WELCOME ON BEAUTYBUZZ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(866, 262);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(866, 309);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 23);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(754, 302);
            label2.Name = "label2";
            label2.Size = new Size(99, 30);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // button1
            // 
            button1.Location = new Point(884, 358);
            button1.Name = "button1";
            button1.Size = new Size(129, 45);
            button1.TabIndex = 4;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(754, 262);
            label3.Name = "label3";
            label3.Size = new Size(106, 30);
            label3.TabIndex = 5;
            label3.Text = "Username";
            // 
            // button2
            // 
            button2.Location = new Point(884, 452);
            button2.Name = "button2";
            button2.Size = new Size(129, 45);
            button2.TabIndex = 6;
            button2.Text = "Register here!";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(884, 434);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 7;
            label4.Text = "Don't have an account?";
            // 
            // BeautyBuzz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1584, 861);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BeautyBuzz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BeautyBuzz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private Label label3;
        private Button button2;
        private Label label4;
    }
}
