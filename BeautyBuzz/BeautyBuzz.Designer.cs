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
            checkBoxLoginPass = new CheckBox();
            labelForgetPass = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.Location = new Point(694, 195);
            label1.Name = "label1";
            label1.Size = new Size(391, 38);
            label1.TabIndex = 0;
            label1.Text = "WELCOME ON BEAUTYBUZZ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(752, 339);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(752, 401);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 27);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 7.8F);
            label2.Location = new Point(661, 407);
            label2.Name = "label2";
            label2.Size = new Size(67, 16);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(819, 456);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 45);
            button1.TabIndex = 4;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.KeyDown += button1_Click_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 7.8F);
            label3.Location = new Point(661, 344);
            label3.Name = "label3";
            label3.Size = new Size(70, 16);
            label3.TabIndex = 5;
            label3.Text = "Username";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            button2.ForeColor = Color.DodgerBlue;
            button2.Location = new Point(809, 529);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(106, 61);
            button2.TabIndex = 6;
            button2.Text = "Register here!";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(791, 505);
            label4.Name = "label4";
            label4.Size = new Size(163, 20);
            label4.TabIndex = 7;
            label4.Text = "Don't have an account?";
            // 
            // checkBoxLoginPass
            // 
            checkBoxLoginPass.AutoSize = true;
            checkBoxLoginPass.Cursor = Cursors.Hand;
            checkBoxLoginPass.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxLoginPass.Location = new Point(1001, 404);
            checkBoxLoginPass.Name = "checkBoxLoginPass";
            checkBoxLoginPass.Size = new Size(124, 20);
            checkBoxLoginPass.TabIndex = 8;
            checkBoxLoginPass.Text = "Show password";
            checkBoxLoginPass.UseVisualStyleBackColor = true;
            checkBoxLoginPass.CheckedChanged += checkBoxLoginPass_CheckedChanged;
            // 
            // labelForgetPass
            // 
            labelForgetPass.AutoSize = true;
            labelForgetPass.Cursor = Cursors.Hand;
            labelForgetPass.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            labelForgetPass.ForeColor = SystemColors.ButtonShadow;
            labelForgetPass.Location = new Point(1016, 427);
            labelForgetPass.Name = "labelForgetPass";
            labelForgetPass.Size = new Size(109, 16);
            labelForgetPass.TabIndex = 9;
            labelForgetPass.Text = "Forget Password";
            labelForgetPass.Click += labelForgetPass_Click;
            // 
            // BeautyBuzz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1371, 887);
            Controls.Add(labelForgetPass);
            Controls.Add(checkBoxLoginPass);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BeautyBuzz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BeautyBuzz";
            Load += BeautyBuzz_Load;
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
        private CheckBox checkBoxLoginPass;
        private Label labelForgetPass;
    }
}
